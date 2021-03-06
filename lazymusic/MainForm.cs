﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Cool_Stuff {
    public partial class MainForm : Form {

        public MainForm () {
            InitializeComponent();
        }

        private void MainForm_Load (object sender, EventArgs e) {
            PopulateBands();
        }

        private void PopulateBands() {
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Band", connection)) {
                DataTable bandTable = new DataTable();
                adapter.Fill(bandTable);
                lstBands.DisplayMember = "Name";
                lstBands.ValueMember = "Id";
                lstBands.DataSource = bandTable;
            }
        }

        private void PopulateSongs () {
            var query = String.Concat("SELECT * FROM Song song ",
                                       "INNER JOIN BandSong bandSong ON song.Id = bandSong.SongId ",
                                       "WHERE bandSong.BandId = @BandId;");

            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command)) {

                command.Parameters.AddWithValue("@BandId", lstBands.SelectedValue);

                DataTable songTable = new DataTable();
                adapter.Fill(songTable);
                lstSongs.DisplayMember = "Title";
                lstSongs.ValueMember = "Id";
                lstSongs.DataSource = songTable;
            }
        }

        private string GetConnectionString () {
            return ConfigurationManager.ConnectionStrings["Cool_Stuff.Properties.Settings.StuffConnectionString"].ConnectionString;
        }

        private void lstBands_SelectedIndexChanged (object sender, EventArgs e) {
            PopulateSongs();
        }

        private void btnAddBandName_Click (object sender, EventArgs e) {
            if (txtBandName.Text == "") {
                MessageBox.Show("Band name field is empty. Please enter a band name.", "Oops");
                return;
            }

            string query = "INSERT INTO Band VALUES (@BandName)";

            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            using (SqlCommand command = new SqlCommand(query, connection)) {
                connection.Open();
                command.Parameters.AddWithValue("@BandName", txtBandName.Text);
                command.ExecuteNonQuery();
            }

            PopulateBands();
        }

        private void btnAddSongTitle_Click (object sender, EventArgs e) {
            AddSongTitle();
        }

        void AddSongTitle () {
            int newSongId = 0;

            if (txtSongName.Text == "") {
                MessageBox.Show("Song name field is empty. Please enter a song name.", "Oops");
                return;
            }

            string query = "INSERT INTO Song OUTPUT INSERTED.Id VALUES (@SongName) ";

            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            using (SqlCommand command = new SqlCommand(query, connection)) {
                connection.Open();
                command.Parameters.AddWithValue("@SongName", txtSongName.Text);
                newSongId = (int)command.ExecuteScalar();
            }

            txtSongName.Text = "";

            //insert into bandsong....
            query = "INSERT INTO BandSong VALUES (@BandId, @SongId)";

            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            using (SqlCommand command = new SqlCommand(query, connection)) {
                connection.Open();
                command.Parameters.AddWithValue("@BandId", lstBands.SelectedValue);
                command.Parameters.AddWithValue("@SongId", newSongId);
                command.ExecuteNonQuery();
            }

            PopulateSongs();
        }

        private void btnClearBandName_Click (object sender, EventArgs e) {
            txtBandName.Text = "";
        }

        private void btnRename_Click (object sender, EventArgs e) {
            string newBandName = Microsoft.VisualBasic.Interaction.InputBox(
                "Please enter a new name for the selected band",
                "Rename Band",
                lstBands.GetItemText(lstBands.SelectedItem).TrimEnd()
                );

            if (newBandName == "") {
                return;
            }

            string query = "UPDATE Band SET Name = @BandName WHERE Id = @BandId";

            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            using (SqlCommand command = new SqlCommand(query, connection)) {
                connection.Open();
                command.Parameters.AddWithValue("@BandName", newBandName);
                command.Parameters.AddWithValue("@BandId", lstBands.SelectedValue);
                command.ExecuteNonQuery();
            }

            PopulateBands();
        }

        private void btnRenameSong_Click (object sender, EventArgs e) {
            string newSongTitle = Microsoft.VisualBasic.Interaction.InputBox(
                "Please enter a new name for the selected song",
                "Rename Song",
                lstSongs.GetItemText(lstSongs.SelectedItem).TrimEnd()
                );

            if (newSongTitle == "") {
                return;
            }

            string query = "UPDATE Song SET Title = @SongTitle WHERE Id = @SongId";

            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            using (SqlCommand command = new SqlCommand(query, connection)) {
                connection.Open();
                command.Parameters.AddWithValue("@SongTitle", newSongTitle);
                command.Parameters.AddWithValue("@SongId", lstSongs.SelectedValue);
                command.ExecuteNonQuery();
            }

            PopulateSongs();
        }

        private void lstSongs_MouseDoubleClick (object sender, MouseEventArgs e) {
            GoogleSong();
        }

        private void lstBands_DoubleClick (object sender, EventArgs e) {
            GoogleBand();
        }

        private void GoogleBand () {
            string bandName = lstBands.GetItemText(lstBands.SelectedItem).TrimEnd();
            Google(bandName);
        }

        private void GoogleSong () {
            string bandName = lstBands.GetItemText(lstBands.SelectedItem).TrimEnd();
            string songName = lstSongs.GetItemText(lstSongs.SelectedItem).TrimEnd();

            Google(bandName + " " + songName);
        }

        private void Google (string searchString) {
            System.Diagnostics.Process.Start(
                "https://www.google.com/#safe=active&q=" + searchString
            );
        }

        private void lstSongs_SelectedIndexChanged (object sender, EventArgs e) {
            
        }

        private void btnDeleteBand_Click (object sender, EventArgs e) {
            DeleteSelectedBand();
        }

        private void btnDeleteSong_Click (object sender, EventArgs e) {
            DeleteSelectedSong();
        }

        private void DeleteSelectedBand () {
            DialogResult result = MessageBox.Show(
                "Are you sure you wanna delete that band?",
                "Confirm Band Deletion",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Information
            );

            if (result != DialogResult.Yes) {
                return;
            }

            string query = "DELETE FROM Band WHERE Id = @BandId";

            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            using (SqlCommand command = new SqlCommand(query, connection)) {
                connection.Open();
                command.Parameters.AddWithValue("@BandId", lstBands.SelectedValue);
                command.ExecuteNonQuery();
            }

            PopulateBands();
        }

        private void DeleteSelectedSong () {
            DialogResult result = MessageBox.Show(
                "Are you sure you wanna delete that song?",
                "Confirm Song Deletion",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Information
            );

            if (result != DialogResult.Yes) {
                return;
            }

            string query = "DELETE FROM BandSong WHERE BandId = @BandId AND SongId = @SongId";

            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            using (SqlCommand command = new SqlCommand(query, connection)) {
                connection.Open();
                command.Parameters.AddWithValue("@BandId", lstBands.SelectedValue);
                command.Parameters.AddWithValue("@SongId", lstSongs.SelectedValue);
                command.ExecuteNonQuery();
            }

            PopulateSongs();
        }

        private void txtSongName_TextChanged (object sender, EventArgs e) {

        }

        private void txtSongName_KeyDown (object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                AddSongTitle();
            }
        }

        private void btnClearSongName_Click (object sender, EventArgs e) {
            txtSongName.Text = "";
        }

        private void lstSongs_KeyDown (object sender, KeyEventArgs e) {
            GoogleSong();
        }

        private void btnGoogleSong_Click (object sender, EventArgs e) {
            GoogleSong();
        }

        private void btnGoogleBand_Click (object sender, EventArgs e) {
            GoogleBand();
        }
    }
}
