using GamelistApp1.Business.Services;
using GamelistApp1.DataAccess;
using GamelistApp1.Domain.Interfaces;
using GamelistApp1.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamelistApp1.WinForms
{
    public partial class GamesOverview : Form
    {
        private readonly IHost _host;
        private readonly IService<Game> _gameService;
        private List<Game> _gameList;

        public GamesOverview()
        {
            InitializeComponent();

            _host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddDbContext<DataContext>(options =>
                        options.UseSqlServer(context.Configuration.GetConnectionString("Default")));
                    services.AddScoped<IRepository<Game>, Repository<Game>>();
                    services.AddScoped<IService<Game>, GameService>();
                })
                .Build();

            _gameService = _host.Services.GetRequiredService<IService<Game>>();

            _gameList = _gameService.GetAll();

            FillListBox();
        }

        private void FillListBox()
        {
            foreach (Game game in _gameList)
            {
                listBox1.Items.Add(game.Title);
            }
        }
    }
}
