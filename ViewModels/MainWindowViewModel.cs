using firfir.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace firfir.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public MainWindowViewModel()
    {


        BlogsEntities = new List<BlogsEntity>
        {
            new BlogsEntity()
            {
                Article = "Happy Birthday",
                Text = "My name is Anton, I’m fifteen years old. My favourite holiday is my birthday. On this day I get up early, but by that time my mother already cooks food for a festive table in the kitchen. In the morning my family and friends begin to give presents and congratulate me. My parents and younger brother always want me to remember this day for a long time that’s why they decorate the flat with many-coloured little balls.\r\n\r\nOn this day a lot of my friends and relations usually come to see me. When we all get together we sit down to table and begin to celebrate my birthday. Everybody has a good time dances and communicates with each other, the music plays loudly. At the end of the holiday we turn off the lights and my father brings a big cake with candles. I must blow out the candles and make a wish. After that we have tea with a cake and then we dismiss the guests.\r\n\r\nI would like to celebrate my birthday every month because all our relations and friends can meet together on this day. I grow up every year but my birthday always remains the most unforgettable holiday of the year..\r\n\r\n",
                Image = "foot.jpg",
                Tags = new List<string> { "Tag1              ", "Tag2              ", "Tag3" }
            },
            new BlogsEntity()
            {
                Article = "Spartak",
                Text = "FC Spartak Moscow (Russian: Футбольный клуб «Спартак» Москва, romanized: Futbolʹnyy klub «Spartak» Moskva, pronounced [spɐrˈtak mɐˈskva]) is a Russian professional football club based in Moscow. Having won 12 Soviet championships (second only to Dynamo Kyiv) and a record 10 Russian championships, it is the country's most successful club. They have also won a record 10 Soviet Cups, 4 Russian Cups and one Russian Super Cup. Spartak have also reached the semi-finals of UEFA Europa cup, UEFA Champions cup and the UEFA cup winner's cup.\r\n\r\n",
                Tags = new List<string> { "Tag1              ", "Tag2              ", "Tag3" }
            },
        };
        NewsEntities = new List<NewsEntity>
        {


                new() { Text = "Школа закончилась\r\n\r\n",
                PublishDate = DateTime.Now },
                new() { Text = "Я играю в футбол 9 лет без 3 месяцев\r\n\r\n",
                PublishDate = DateTime.Now.AddDays(-7) }

        };
    }
    public List<BlogsEntity> BlogsEntities { get; set; }
    public List<NewsEntity> NewsEntities { get; set; }
}
