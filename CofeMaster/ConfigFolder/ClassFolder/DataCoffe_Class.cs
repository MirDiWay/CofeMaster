using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofeMaster.ConfigFolder.ClassFolder
{
    public class DataCoffe_Class
    {
        public string NameCoffee { get; set; }
        public string DescriptionCoffee { get; set; }
        public string ImagePathCoffee { get; set; }
        public string CookingCoffee { get; set; }
        public string CaloriesCoffee { get; set; }
        public List<string> IngredientsCoffee { get; set; }
    }

    public static class CoffeeRepository
    {
        public static List<DataCoffe_Class> Coffees = new List<DataCoffe_Class>
        {
            new DataCoffe_Class
            {
                NameCoffee = "Эспрессо",
                DescriptionCoffee = "Описание",
                ImagePathCoffee = "/ConfigFolder/ContentFolder/ImageFolder/ImageCoffee9.png",
                CookingCoffee = "Как готовить",
                CaloriesCoffee = "120",
                IngredientsCoffee = new List<string>
                {
                    "Молоко 120 мл",
                    "Вода 40 мл",
                    "Кофе 50 мл"
                }
            },

            new DataCoffe_Class
            {
                NameCoffee = "Маккьято",
                DescriptionCoffee = "Описание",
                ImagePathCoffee = "/ConfigFolder/ContentFolder/ImageFolder/ImageCoffee2.png",
                CookingCoffee = "Как готовить",
                CaloriesCoffee = "120",
                IngredientsCoffee = new List<string>
                {
                   "Молоко 120 мл",
                    "Вода 40 мл",
                    "Кофе 50 мл"
                }
            },
            new DataCoffe_Class
            {
                NameCoffee = "Капучино",
                DescriptionCoffee = "Описание",
                ImagePathCoffee = "/ConfigFolder/ContentFolder/ImageFolder/ImageCoffee3.png",
                CookingCoffee = "Как готовить",
                CaloriesCoffee = "120",
                IngredientsCoffee = new List<string>
                {
                    "Молоко 120 мл",
                    "Вода 40 мл",
                    "Кофе 50 мл"
                }
            },
            new DataCoffe_Class
            {
                NameCoffee = "Мароккино",
                ImagePathCoffee = "/ConfigFolder/ContentFolder/ImageFolder/ImageCoffee4.png"
            },
            new DataCoffe_Class
            {
                NameCoffee = "РАФ",
                ImagePathCoffee = "/ConfigFolder/ContentFolder/ImageFolder/ImageCoffee2.png"
            },
            new DataCoffe_Class
            {
                NameCoffee = "Гляссе",
                ImagePathCoffee = "/ConfigFolder/ContentFolder/ImageFolder/ImageCoffee2.png"
            },
            new DataCoffe_Class
            {
                NameCoffee = "Допио",
                ImagePathCoffee = "/ConfigFolder/ContentFolder/ImageFolder/ImageCoffee7.png"
            },
            new DataCoffe_Class
            {
                NameCoffee = "Американо",
                ImagePathCoffee = "/ConfigFolder/ContentFolder/ImageFolder/ImageCoffee10.png"
            },
            new DataCoffe_Class
            {
                NameCoffee = "Латте",
                ImagePathCoffee = "/ConfigFolder/ContentFolder/ImageFolder/ImageCoffee3.png"
            },
            new DataCoffe_Class
            {
                NameCoffee = "Мокко",
                ImagePathCoffee = "/ConfigFolder/ContentFolder/ImageFolder/ImageCoffee10.png"
            },
            new DataCoffe_Class
            {
                NameCoffee = "Медовый РАФ",
                ImagePathCoffee = "/ConfigFolder/ContentFolder/ImageFolder/ImageCoffee11.png"
            },
            new DataCoffe_Class
            {
                NameCoffee = "Фраппе",
                ImagePathCoffee = "/ConfigFolder/ContentFolder/ImageFolder/ImageCoffee12.png"
            },
            new DataCoffe_Class
            {
                NameCoffee = "Лунго",
                ImagePathCoffee = "/ConfigFolder/ContentFolder/ImageFolder/ImageCoffee1.png"
            },
            new DataCoffe_Class
            {
                NameCoffee = "Со сливками",
                ImagePathCoffee = "/ConfigFolder/ContentFolder/ImageFolder/ImageCoffee2.png"
            },
            new DataCoffe_Class
            {
                NameCoffee = "Флет Уайт",
                ImagePathCoffee = "/ConfigFolder/ContentFolder/ImageFolder/ImageCoffee3.png"
            },
            new DataCoffe_Class
            {
                NameCoffee = "Бичерин",
                ImagePathCoffee = "/ConfigFolder/ContentFolder/ImageFolder/ImageCoffee4.png"
            },
            new DataCoffe_Class
            {
                NameCoffee = "По-венски",
                ImagePathCoffee = "/ConfigFolder/ContentFolder/ImageFolder/ImageCoffee5.png"
            },
            new DataCoffe_Class
            {
                NameCoffee = "Фреддо",
                ImagePathCoffee = "/ConfigFolder/ContentFolder/ImageFolder/ImageCoffee6.png"
            },
            new DataCoffe_Class
            {
                NameCoffee = "Ристретто",
                ImagePathCoffee = "/ConfigFolder/ContentFolder/ImageFolder/ImageCoffee7.png"
            },
            new DataCoffe_Class
            {
                NameCoffee = "По римски",
                ImagePathCoffee = "/ConfigFolder/ContentFolder/ImageFolder/ImageCoffee8.png"
            },
            new DataCoffe_Class
            {
                NameCoffee = "Бреве",
                ImagePathCoffee = "/ConfigFolder/ContentFolder/ImageFolder/ImageCoffee9.png"
            },
            new DataCoffe_Class
            {
                NameCoffee = "Латте Маккьято",
                ImagePathCoffee = "/ConfigFolder/ContentFolder/ImageFolder/ImageCoffee10.png"
            },
            new DataCoffe_Class
            {
                NameCoffee = "По ирландски",
                ImagePathCoffee = "/ConfigFolder/ContentFolder/ImageFolder/ImageCoffee11.png"
            },
            new DataCoffe_Class
            {
                NameCoffee = "Карамельный Фраппе",
                ImagePathCoffee = "/ConfigFolder/ContentFolder/ImageFolder/ImageCoffee12.png"
            },
            new DataCoffe_Class
            {
                NameCoffee = "Капучино Фреддо",
                ImagePathCoffee = "/ConfigFolder/ContentFolder/ImageFolder/ImageCoffee1.png"
            },
            new DataCoffe_Class
            {
                NameCoffee = "Эспрессо Лачино",
                ImagePathCoffee = "/ConfigFolder/ContentFolder/ImageFolder/ImageCoffee2.png"
            }
        };
    }
}
