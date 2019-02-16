using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPF_MasterDetailApp;
using WPF_MasterDetailApp.Models;

namespace WPF_MasterDetailApp.BusinessLayer
{
    public class ProductBL
    {
        #region ENUMS



        #endregion

        #region FIELDS

        ProductWindowView _productWindowView;
        ProductWindowPresenter _productWindowPresenter;

        #endregion

        #region PROPERTIES

        #endregion

        #region CONSTRUCTORS

        public ProductBL()
        {
            //
            // instantiate the view model and initialize the data set
            //

            _productWindowPresenter = new ProductWindowPresenter(GetCompanyData(), GetProductData());

            //
            // instantiate, set the data context, and show the Main Window
            //
            _productWindowView = new ProductWindowView(_productWindowPresenter);
            _productWindowView.DataContext = _productWindowPresenter;
            _productWindowView.Show();
        }

        #endregion

        #region METHODS

        private Company GetCompanyData()
        {
            return new Company()
            {
                Name = "Monsters in the Monster Hunter World!",
            };
        }

        private Product GetProductData()
        {
            return
                new Product()
                {
                    Name = "Rathalos",
                    MonsterType = "Large",
                    MonsterElement = Product.Element.FIRE,
                    Weakness = Product.Element.THUNDER,
                    Size = 73.8,
                    Generation = 1,
                    ImageFileName = "Rathalos.png",
                    Description = "Rathalos are large, bipedal wyverns with a spiny, armored hide covering their body. Their outer shell features much brighter and more vibrant colors than that of their female counterpart, the Rathian. It is primarily bright red, with black markings throughout. Like the Rathian, Rathalos possess a flame sac which is used to produce deadly flaming projectiles from the mouth. The talons upon their feet are highly poisonous and are known to to inflict toxic mortal wounds on larger prey. In addition, their long, thick tail features a heavy spiked club at the end. Rathalos' wing membranes feature ornate patterns which are likely used to attract potential mates.",
                };
        }

        #endregion

        #region EVENTS


        #endregion

    }
}
