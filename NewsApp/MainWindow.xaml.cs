using NewsApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NewsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NewsList list;
        public MainWindow()
        {
            list = new NewsList();
            list.AddNews(new News("NEWS","Important news","","19.10.2023"));
            list.AddNews(new News("San Cristóbal de las Casas: A Tapestry of Indigenous Cultures", "Nestled in the Chiapas highlands, San Cristóbal de las Casas is a hub of indigenous cultures and breathtaking scenery. Explore the colorful markets and immerse yourself in the traditions of the Maya and Chiapas communities. Nearby, the natural wonder of Sumidero Canyon offers a boat ride through dramatic cliffs and lush wildlife.", "Maria Ivanovna Kovalenko", "19.10.2023"));
            list.AddNews(new News("Chichén Itzá: Echoes of an Ancient Civilization", "Journey to the Yucatán Peninsula to witness the awe-inspiring ruins of Chichén Itzá. This archaeological site is a testament to the advanced engineering and astronomical knowledge of the ancient Maya. The grandeur of El Castillo and the sacred cenote leave an indelible mark on all who visit.", "Maria Ivanovna Kovalenko", "19.10.2023"));
            list.AddNews(new News("Guadalajara: Tequila, Mariachi, and Colonial Charm", "Guadalajara, the birthplace of mariachi music and tequila, exudes a lively atmosphere. Explore the historic district of Tlaquepaque, known for its artisan workshops and lively plazas. Immerse yourself in the vibrant music scene and savor the flavors of traditional Mexican cuisine.", "Maria Ivanovna Kovalenko", "19.10.2023"));
            list.AddNews(new News("Oaxaca: A Tapestry of Tradition and Artistry", "Oaxaca, a UNESCO World Heritage city, is a tapestry of indigenous culture, culinary artistry, and vibrant markets. Wander through the historic center, admiring the colonial architecture and colorful markets. Don't miss the opportunity to savor the region's renowned cuisine, including mole and mezcal.", "Maria Ivanovna Kovalenko", "19.10.2023"));
            InitializeComponent();
        }
    }
}
