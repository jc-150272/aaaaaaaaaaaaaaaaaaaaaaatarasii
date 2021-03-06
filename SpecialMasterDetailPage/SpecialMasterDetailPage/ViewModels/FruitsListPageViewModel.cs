﻿using System.Collections.Generic;
using Kamishibai.Xamarin.Forms.Mvvm;
using Xamarin.Forms;

namespace SpecialMasterDetailPage.ViewModels
{
    public class FruitsListPageViewModel : ViewModelBase
    {
        /// <summary>
        /// List of fruits.
        /// </summary>
        public IList<Fruit> Fruits { get; } = new List<Fruit>();
        
        /// <summary>
        /// Request navigation with the selected Fruit.
        /// </summary>
        public NavigationRequestCommand<Fruit> NavigateDetailRequestCommand { get; } = new NavigationRequestCommand<Fruit>();

        /// <summary>
        /// Initialize Instance.
        /// </summary>
        public FruitsListPageViewModel()
        {
            Fruits.Add(new Fruit { Name = "Apple", Color = Color.Red });
            Fruits.Add(new Fruit { Name = "Orange", Color = Color.Orange });
            Fruits.Add(new Fruit { Name = "Pineapple", Color = Color.Orange });
            Fruits.Add(new Fruit { Name = "Banana", Color = Color.Goldenrod });
            Fruits.Add(new Fruit { Name = "Peach", Color = Color.DeepPink });
            Fruits.Add(new Fruit { Name = "Mango", Color = Color.Goldenrod });
            Fruits.Add(new Fruit { Name = "Melon", Color = Color.Green });
            Fruits.Add(new Fruit { Name = "Grape", Color = Color.Purple });
            Fruits.Add(new Fruit { Name = "Strawberry", Color = Color.Red });
        }
    }
}
