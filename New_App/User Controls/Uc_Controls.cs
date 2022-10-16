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
        Movie = movie;
        labelNamemovie.Text = movie.Title;
        labelYear.Text = movie.Year;
        labelJanre.Text = movie.Genre;
        labelCountry.Text = movie.Country;
        labelPremier.Text = movie.Released;
        labelQuality.Text = "Full HD";
        pictureBox1.LoadAsync(movie?.Poster);
    }

    public Uc_Controls()
    {
    }
}
