using New_App.Repository;
using System.Text.Json;
using System.Windows.Forms;
using New_App.Repository;
using New_App.Models;
using New_App.User_Controls;

namespace New_App;

public partial class Form1 : Form
{
    const string _apiKey = "5094dfd3";
    const string _url = $"http://www.omdbapi.com/?apikey={_apiKey}";
    string jsonStr;

    public Form1()
    {
        InitializeComponent();
    }

    private async void button1_Click(object sender, EventArgs e)
    {
        string search = $"{_url}&t={SearchtextBox.Text}";
        string wrongsearch = $"{_url}&t=...";


        using HttpClient client = new();
        string jsonStr = await client.GetStringAsync(search);
        string wronginfo = await client.GetStringAsync(wrongsearch);



        if (jsonStr == wronginfo)
        {
            MessageBox.Show("Bele kino yoxdur");
            return;
        }
        var movie = JsonSerializer.Deserialize<Models.Movie>(jsonStr);


        //pictureBox1.LoadAsync(movie?.Poster);
    }

    private async void Form1_Load(object sender, EventArgs e)
    {
        using HttpClient client = new();
        foreach (var item in Fakedata.MovieNames)
        {

            jsonStr = await client.GetStringAsync($"{_url}&t={item}&plot=full");
            var movie = JsonSerializer.Deserialize<Movie>(jsonStr);
            flowLayoutPanel1.Controls.Add(new Uc_Controls(movie));
           
        }
    }

   
}