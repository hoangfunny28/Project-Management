using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Contacts;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Microsoft.Toolkit.Uwp.UI.Controls;
using Windows.UI.Xaml.Media.Imaging;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Product_Management
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.Products = new ObservableCollection<Product>();

            ObservableCollection<IconFile> iconFiles = new ObservableCollection<IconFile>();
            iconFiles.Add(new IconFile() { IconFiles = "/Assets/Animals/Cat.png" });
            iconFiles.Add(new IconFile() { IconFiles = "/Assets/Animals/Cow.png" });
            iconFiles.Add(new IconFile() { IconFiles = "/Assets/Cartoons/Gun.png" });
            iconFiles.Add(new IconFile() { IconFiles = "/Assets/Cartoons/Spring.png" });
            iconFiles.Add(new IconFile() { IconFiles = "/Assets/Taunts/Clock.png" });
            iconFiles.Add(new IconFile() { IconFiles = "/Assets/Taunts/LOL.png" });
            iconFiles.Add(new IconFile() { IconFiles = "/Assets/Warnings/Ship.png" });
            iconFiles.Add(new IconFile() { IconFiles = "/Assets/Warnings/Siren.png" });
            


            this.DataContext = this;
        }
        public ObservableCollection<Product> Products { get; set; }
        public List<Image> Images { get; set; }

         void Button_Click(object sender, RoutedEventArgs e)
        {
            string productName = txtproductName.Text;
            string productDescription = txtproductDescription.Text;
            
            if (productName != null && productDescription != null)
            {
                Product product = new Product { Name = productName, Description = productDescription };
                
                this.Products.Add(product);
            }
        }

        
    }

    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        
        
    }
    public class IconFile
    {
        public string IconFiles { get; set; }
    }

    

}

    

