using LV.model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LV
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            Populate();
		}
       
        private void Populate()
        {
            var ImageListView = new ObservableCollection<ImageCellItem>()
            {
                new ImageCellItem()
                {
                    ImageText = "Naruto",
                    IDetail = "This is is an Anime about ninjas fighting to become better ninjas. The main character nruto is aiming to become the hokage the leader of the village",
                    IconSource = ImageSource.FromFile("naruto.jpg"),
                    URL = "http://naruto.wikia.com/wiki/Narutopedia"
                },
                 new ImageCellItem()
                {
                    ImageText = "Noragami",
                    IDetail = "This is is an Anime about GODS who can do no wrong. Yato is the main character a Good trying to get back into heaven",
                    IconSource = ImageSource.FromFile("nora.jpg"),
                    URL = "https://en.wikipedia.org/wiki/Noragami"
                },
                  new ImageCellItem()
                {
                    ImageText = "HunterxHunter",
                    IDetail = "This is is an Anime about fighting using nen. Gon the main character is on a mission trying to find his dad and the reason his dad left",
                    IconSource = ImageSource.FromFile("Hunter.jpg"),
                    URL = "https://en.wikipedia.org/wiki/Hunter_%C3%97_Hunter"
                },
                   new ImageCellItem()
                {
                    ImageText = "Detective conan",
                    IDetail = "This is is an Anime about a boy who solves crimes. He was  highschool student that got turned into a kid",
                    IconSource = ImageSource.FromFile("Conan.jpg"),
                    URL = "http://www.detectiveconanworld.com/wiki/"
                },
                    new ImageCellItem()
                {
                    ImageText = "Fate/Zero",
                    IDetail = "This is is an Anime about heros coming back to life to fight for the holy grail. Whoever whens the Holy grail get to make a wish",
                    IconSource = ImageSource.FromFile("Fate.jpg"),
                    URL = "https://en.wikipedia.org/wiki/Fate/Zero"
                },
                     new ImageCellItem()
                {
                    ImageText = "Dragon ball Super",
                    IDetail = "This is is an Anime about Goku defeating all his enemies. Right now the are fighting to keep the universe alive",
                    IconSource = ImageSource.FromFile("DBS.jpg"),
                    URL = "https://en.wikipedia.org/wiki/Dragon_Ball_Super"
                },
                      new ImageCellItem()
                {
                    ImageText = "erased",
                    IDetail = "This is is an Anime about getting to do things over until he solves the murder case. He goes back in time to when he was a kid to stop the death of his classmate",
                    IconSource = ImageSource.FromFile("erased.jpg"),
                    URL = "https://en.wikipedia.org/wiki/Erased_(manga)"
                },
                       new ImageCellItem()
                {
                    ImageText = "My hero academia",
                    IDetail = "This is is an Anime about Heros who fight villians. A weak kid with no powerr gets the powers of the strongest hero and tries to become a hero",
                    IconSource = ImageSource.FromFile("MyHero.jpg"),
                    URL = "https://en.wikipedia.org/wiki/My_Hero_Academia"
                }
            };
            ImageCList.ItemsSource = ImageListView;
        }
        void Handle_Tapped(object sender, System.EventArgs e)
        {
            var ListViewUrl = (ImageCell)sender;
            var url = (string)ListViewUrl.CommandParameter;
            Device.OpenUri(new Uri(url));
        }

	}
}
