using Microsoft.VisualBasic.Devices;
using New_App.Forms;
using New_App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_App.User_Controls;

public partial class Uc_Controls : UserControl
{
    Movie Movie { get; set; }

    public Uc_Controls(Movie movie)
    {
        InitializeComponent();

        //panel1.ForeColor = ColorTranslator.FromHtml("#3C887E");
        //panel1.BackColor = ColorTranslator.FromHtml("#A17C6B");
        label1.BackColor = ColorTranslator.FromHtml("#DFA069");
        label2.BackColor = ColorTranslator.FromHtml("#DFA069");
        label3.BackColor = ColorTranslator.FromHtml("#DFA069");
        label4.BackColor = ColorTranslator.FromHtml("#DFA069");
        Movie = movie;
        labelNamemovie.Text = movie.Title;
        labelYear.Text = $"Year: {movie.Year}";
        labelJanre.Text = $"imdbRating: {movie.imdbRating}";
        labelCountry.Text = $"Country: {movie.Country}";
        labelTime.Text = $"Run Time: {movie.Runtime}";
        labelPremier.Text = $"Premier: {movie.Released}";
        labelQuality.Text = $"Full HD";
        pictureBox1.LoadAsync(movie?.Poster);
    }

    public Uc_Controls()
    {
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {

        InfoFilm infoFilm = new(Movie);
        infoFilm.Show();
    }
}
