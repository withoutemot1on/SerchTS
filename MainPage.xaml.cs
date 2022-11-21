using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace MauiApp2;

public partial class MainPage : ContentPage
{
	public ObservableCollection<Hero> sword { get; set; }
	public Hero client1 { get; set; }
	public Hero client2 { get; set; }
	public Hero client3 { get; set; }
	public Hero client4 { get; set; }

	public MainPage()
    {

        client1 = new Hero("Магомед", "Collapse", "Халилов");
        client2 = new Hero("Александр ", "TORONTOTOKYO", "Хертек ");
        client3 = new Hero("Мирослав", "Mira", "Колпаков");
        client4 = new Hero("Ярослав", "Miposhka", "Найденов");

		sword = new ObservableCollection<Hero>();
        sword.Add(client1);
        sword.Add(client2);
        sword.Add(client3);
        sword.Add(client4);

		BindingContext = this;
        InitializeComponent();
    }


    private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
	{
        SearchBar s = sender as SearchBar;
        var g = (s.Parent as VerticalStackLayout).Children;
        for (int i = 0; i < sword.Count; i++)
        {
            if (e.NewTextValue != "")
            {
                if (sword[i].Name.Contains(e.NewTextValue))
                {
                    (g[i + 1] as Grid).BackgroundColor = Color.Parse("Green");
                    continue;
                }

                else if (sword[i].Surname.Contains(e.NewTextValue))
                {
                    (g[i + 1] as Grid).BackgroundColor = Color.Parse("Green");
                    continue;
                }

                else if (sword[i].Patronymic.Contains(e.NewTextValue))
                {
                    (g[i + 1] as Grid).BackgroundColor = Color.Parse("Green");
                    continue;
                }
                else
                {
                    (g[i + 1] as Grid).BackgroundColor = Color.Parse("White");
                }

            }
            else
            {
                (g[i + 1] as Grid).BackgroundColor = Color.Parse("White");
            }
        }
    }

	private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
	{
		SearchBar s = sender as SearchBar;
		var g = (s.Parent as VerticalStackLayout).Children;
        for (int i = 0; i < sword.Count; i++)
        {

            if (sword[i].Name.Contains(s.Text))
            {
                (g[i + 1] as Grid).BackgroundColor = Color.Parse("Orange");
            }

            else if (sword[i].Surname.Contains(s.Text))
            {
                (g[i + 1] as Grid).BackgroundColor = Color.Parse("Orange");
            }

            else if (sword[i].Patronymic.Contains(s.Text))
            {
                (g[i + 1] as Grid).BackgroundColor = Color.Parse("Orange");
            }

            else
            {
                (g[i + 1] as Grid).BackgroundColor = Color.Parse("White");
            }

        }
    }

	

}

