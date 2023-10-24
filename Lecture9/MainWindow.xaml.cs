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

namespace Lecture9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //new students favorite colors

        //hafsa - black
        //matthew - orange
        //benel - green
        //david - pink
        //kira - purple
        //juan - light cornflower blue
        //manjula - red

        List<string> studentsFavoriteColors = new List<string>();


        public MainWindow()
        {
            InitializeComponent();

            //a list uses indexes
            //a collection always starts a 0

            //to add to a list you do listName.Add(object)
            //.Add()
            //when you add an item to the list it adds it one after another

            //rtbDisplay.Text = ""; - this will clear richtxtbox text
            
            studentsFavoriteColors.Add("hafsa - black");  //[0]
            studentsFavoriteColors.Add("matthew - orange");  //[1]
            studentsFavoriteColors.Add("benel - green");  //[2]
            studentsFavoriteColors.Add("david - pink");  //[3]
            studentsFavoriteColors.Add("kira - purple");  //[4]
            studentsFavoriteColors.Add("juan - light cornflower blue");  //[5]
            studentsFavoriteColors.Add("manjula - red"); //[6]
            studentsFavoriteColors.Add("will - white");  //[7]

            //rtbDisplay.Text = studentsFavoriteColors[0];

            for(int i = 0; i < studentsFavoriteColors.Count; i++)
            {
                string currentColor = studentsFavoriteColors[i];

                rtbDisplay.Text += currentColor + "\n";
            }




            //double[] listOfDoubles = new double[10];

            ////get the .Count
            //rtbDisplay.Text = "";

            //for(int i = 0; i < listOfDoubles.Length; i++)
            //{
            //    rtbDisplay.Text += i + " + listOfDoubles[i] + \n"; 
            //}


        } //mainwidow

        //rtbDisplay.Text = "Hafsa's favorirte color is black";
        //rtbDisplay.Text += "\nMatthew's favorite color is orange";

        //a collection in programming is any data structure
        //that holds multiple variables of the same type

        //array or list

        //Lists<type> listName = new List<type> 
        //create a list of student names
        //we need to keep track of a first and a last name
        List<string> studentNames = new List<string>();

        //add
        //access a single element
        //remove

    }//class

}//namespace
