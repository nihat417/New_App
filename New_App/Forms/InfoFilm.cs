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

namespace New_App.Forms;

public partial class InfoFilm : Form
{
    public Movie Movie { get; set; }

    public InfoFilm(Movie movie)
    {
        InitializeComponent();
        panel1.BackColor = ColorTranslator.FromHtml("#262730");
        panel2.BackColor = ColorTranslator.FromHtml("#262730");
        panel3.BackColor = ColorTranslator.FromHtml("#262730");
        panel4.BackColor = ColorTranslator.FromHtml("#FF8811");
        richTextBox1.BackColor = ColorTranslator.FromHtml("#A0ACAD");
        Movie = movie;
        labelNamemovie.Text = movie.Title;
        labelYear.Text = $"Year: {movie.Year}";
        labelJanre.Text = $"imdbRating: {movie.imdbRating}";
        labelCountry.Text = $"Country: {movie.Country}";
        labelPremier.Text = $"Premier: {movie.Released}";
        labelTime.Text = $"Run Time: {movie.Runtime}";
        labelQuality.Text = "Full HD";
        richTextBox1.Text = $"{movie.Plot}";
        label1.Text = $"Movie Language: {movie.Language}";
        pictureBox1.LoadAsync(movie?.Poster);

    }
}
