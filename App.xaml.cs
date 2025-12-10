using MauiProjektSzGSzA.mvvm.model;
using MauiProjektSzGSzA.mvvm.view;
using MauiProjektSzGSzA.repository;

namespace MauiProjektSzGSzA
{
    public partial class App : Application
    {
        public static BaseRepository<Film> FilmRepo { get; private set; }
        public App(BaseRepository<Film> repo)
        {
            InitializeComponent();
            FilmRepo = repo;
            MainPage = new NavigationPage(new FilmView());
        }
    }
}
