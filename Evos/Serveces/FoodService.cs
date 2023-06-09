﻿using Evos.Interfaces;
using Evos.Models;

namespace Evos.Serveces
{
    public class FoodService : IProductManager
    {
        private List<Food> Foods { get; set; } = MockDatas.Data.Foods;

        // Add Food
        public bool AddFood(Food food)
        {
            Food newFood = new Food();

            foreach (Food inFood in Foods)
            {
                if (inFood.Name == food.Name)
                {
                    return false;
                }
            }
            Foods.Add(food);

            return true;
        }

        // Delete Food
        public bool DeleteFood(string foodName)
        {
            Food existFood = new Food();
            foreach (Food food in Foods)
            {
                if (food.Name == foodName)
                {
                    existFood = food;
                    Foods.Remove(existFood);

                    return true;
                }
            }
            return false;
        }

        // Get All
        public List<Food> GetAllFoods()
        {
            return Foods;
        }

        // Get Food
        public Food GetFood(string foodName)
        {
            foreach (Food food in Foods)
            {
                if (food.Name == foodName)
                    return food;
            }
            return null;
        }
    }
}
