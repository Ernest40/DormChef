using DormChef.Models;

namespace DormChef.Services
{
    public class MealDataService
    {
        private readonly List<Meal> _meals;

        public MealDataService()
        {
            _meals = new List<Meal>
            {
                // BREAKFAST
                new Meal
                {
                    Id = 1,
                    Name = "Egg Sandwich",
                    Category = "Breakfast",
                    ImagePath = "egg_sandwich.png",
                    Description = "A quick and filling sandwich made with eggs and bread.",
                    PrepTime = "10 mins",
                    Ingredients = new List<string>
                    {
                        "2 slices bread",
                        "2 eggs",
                        "1 tbsp butter",
                        "Salt",
                        "Black pepper"
                    },
                    Steps = new List<string>
                    {
                        "Crack eggs into a bowl and whisk.",
                        "Heat butter in a pan.",
                        "Cook the eggs until done.",
                        "Toast the bread lightly.",
                        "Place eggs between bread slices and serve."
                    }
                },
                new Meal
                {
                    Id = 2,
                    Name = "Oatmeal with Banana",
                    Category = "Breakfast",
                    ImagePath = "oatmeal_banana.png",
                    Description = "Warm oatmeal topped with banana for a simple breakfast.",
                    PrepTime = "7 mins",
                    Ingredients = new List<string>
                    {
                        "1 cup oats",
                        "1 banana",
                        "1 cup milk or water",
                        "1 tsp honey"
                    },
                    Steps = new List<string>
                    {
                        "Boil milk or water.",
                        "Add oats and stir until soft.",
                        "Slice banana on top.",
                        "Drizzle with honey and serve."
                    }
                },
                new Meal
                {
                    Id = 3,
                    Name = "French Toast",
                    Category = "Breakfast",
                    ImagePath = "french_toast.png",
                    Description = "Simple French toast made with pantry ingredients.",
                    PrepTime = "12 mins",
                    Ingredients = new List<string>
                    {
                        "2 slices bread",
                        "2 eggs",
                        "1/4 cup milk",
                        "1 tsp sugar",
                        "Butter"
                    },
                    Steps = new List<string>
                    {
                        "Whisk eggs, milk, and sugar.",
                        "Dip bread into the mixture.",
                        "Heat butter in a pan.",
                        "Cook both sides until golden brown.",
                        "Serve warm."
                    }
                },
                new Meal
                {
                    Id = 4,
                    Name = "Breakfast Burrito",
                    Category = "Breakfast",
                    ImagePath = "breakfast_burrito.png",
                    Description = "A fast breakfast wrap with eggs and cheese.",
                    PrepTime = "10 mins",
                    Ingredients = new List<string>
                    {
                        "1 tortilla",
                        "2 eggs",
                        "1/4 cup shredded cheese",
                        "1 tbsp butter"
                    },
                    Steps = new List<string>
                    {
                        "Cook eggs in a pan.",
                        "Place eggs on tortilla.",
                        "Add cheese.",
                        "Roll tightly and serve."
                    }
                },
                new Meal
                {
                    Id = 5,
                    Name = "Yogurt and Granola Bowl",
                    Category = "Breakfast",
                    ImagePath = "yogurt_granola.png",
                    Description = "A light breakfast bowl with yogurt and granola.",
                    PrepTime = "5 mins",
                    Ingredients = new List<string>
                    {
                        "1 cup yogurt",
                        "1/2 cup granola",
                        "Honey",
                        "Fruit slices"
                    },
                    Steps = new List<string>
                    {
                        "Add yogurt to a bowl.",
                        "Top with granola.",
                        "Add fruit slices.",
                        "Drizzle with honey and serve."
                    }
                },

                // LUNCH
                new Meal
                {
                    Id = 11,
                    Name = "Grilled Cheese Sandwich",
                    Category = "Lunch",
                    ImagePath = "grilled_cheese.png",
                    Description = "A crispy cheese sandwich that is quick and affordable.",
                    PrepTime = "8 mins",
                    Ingredients = new List<string>
                    {
                        "2 slices bread",
                        "2 slices cheese",
                        "1 tbsp butter"
                    },
                    Steps = new List<string>
                    {
                        "Butter the bread.",
                        "Place cheese between slices.",
                        "Cook in a pan until golden on both sides.",
                        "Slice and serve."
                    }
                },
                new Meal
                {
                    Id = 12,
                    Name = "Turkey Wrap",
                    Category = "Lunch",
                    ImagePath = "turkey_wrap.png",
                    Description = "A simple wrap packed with turkey and fresh vegetables.",
                    PrepTime = "6 mins",
                    Ingredients = new List<string>
                    {
                        "1 tortilla wrap",
                        "Turkey slices",
                        "Lettuce",
                        "Tomato slices",
                        "Mayonnaise"
                    },
                    Steps = new List<string>
                    {
                        "Lay tortilla flat.",
                        "Spread mayonnaise on the wrap.",
                        "Add turkey, lettuce, and tomato.",
                        "Roll tightly and cut in half."
                    }
                },
                new Meal
                {
                    Id = 13,
                    Name = "Chicken Fried Rice",
                    Category = "Lunch",
                    ImagePath = "chicken_fried_rice.png",
                    Description = "A quick fried rice meal using leftover rice and simple ingredients.",
                    PrepTime = "15 mins",
                    Ingredients = new List<string>
                    {
                        "2 cups cooked rice",
                        "1 cup cooked chicken",
                        "1 egg",
                        "Soy sauce",
                        "Mixed vegetables"
                    },
                    Steps = new List<string>
                    {
                        "Heat oil in a pan.",
                        "Scramble the egg first.",
                        "Add vegetables and chicken.",
                        "Add rice and soy sauce.",
                        "Stir well and cook for a few minutes."
                    }
                },
                new Meal
                {
                    Id = 14,
                    Name = "Tuna Sandwich",
                    Category = "Lunch",
                    ImagePath = "tuna_sandwich.png",
                    Description = "An easy tuna sandwich for a filling midday meal.",
                    PrepTime = "7 mins",
                    Ingredients = new List<string>
                    {
                        "2 slices bread",
                        "1 can tuna",
                        "1 tbsp mayonnaise",
                        "Lettuce"
                    },
                    Steps = new List<string>
                    {
                        "Drain the tuna.",
                        "Mix tuna with mayonnaise.",
                        "Spread onto bread.",
                        "Add lettuce and close sandwich."
                    }
                },
                new Meal
                {
                    Id = 15,
                    Name = "Pasta Salad",
                    Category = "Lunch",
                    ImagePath = "pasta_salad.png",
                    Description = "Cold pasta salad that is easy to prepare ahead of time.",
                    PrepTime = "15 mins",
                    Ingredients = new List<string>
                    {
                        "2 cups cooked pasta",
                        "Cherry tomatoes",
                        "Cucumber",
                        "Salad dressing"
                    },
                    Steps = new List<string>
                    {
                        "Cook and cool the pasta.",
                        "Cut tomatoes and cucumber.",
                        "Mix all ingredients in a bowl.",
                        "Add dressing and toss."
                    }
                },

                // DINNER
                new Meal
                {
                    Id = 21,
                    Name = "Spaghetti",
                    Category = "Dinner",
                    ImagePath = "spaghetti.png",
                    Description = "Classic spaghetti with simple sauce.",
                    PrepTime = "20 mins",
                    Ingredients = new List<string>
                    {
                        "Spaghetti pasta",
                        "Pasta sauce",
                        "Ground beef or turkey",
                        "Salt",
                        "Water"
                    },
                    Steps = new List<string>
                    {
                        "Boil water and cook spaghetti.",
                        "Cook meat in a pan.",
                        "Add sauce to the meat.",
                        "Drain pasta and combine.",
                        "Serve hot."
                    }
                },
                new Meal
                {
                    Id = 22,
                    Name = "Chicken Quesadilla",
                    Category = "Dinner",
                    ImagePath = "chicken_quesadilla.png",
                    Description = "Cheesy quesadilla with chicken for a simple dinner.",
                    PrepTime = "12 mins",
                    Ingredients = new List<string>
                    {
                        "2 tortillas",
                        "1 cup cooked chicken",
                        "1 cup shredded cheese",
                        "Butter"
                    },
                    Steps = new List<string>
                    {
                        "Place tortilla in a pan.",
                        "Add cheese and chicken.",
                        "Cover with another tortilla.",
                        "Cook both sides until golden.",
                        "Cut into slices and serve."
                    }
                },
                new Meal
                {
                    Id = 23,
                    Name = "Vegetable Stir Fry",
                    Category = "Dinner",
                    ImagePath = "veggie_stir_fry.png",
                    Description = "A fast vegetable stir fry for a healthy dinner.",
                    PrepTime = "15 mins",
                    Ingredients = new List<string>
                    {
                        "Mixed vegetables",
                        "Soy sauce",
                        "Garlic",
                        "Oil",
                        "Cooked rice"
                    },
                    Steps = new List<string>
                    {
                        "Heat oil in a pan.",
                        "Add garlic and vegetables.",
                        "Stir fry until tender.",
                        "Add soy sauce.",
                        "Serve over cooked rice."
                    }
                },
                new Meal
                {
                    Id = 24,
                    Name = "Ramen with Vegetables",
                    Category = "Dinner",
                    ImagePath = "ramen_veggies.png",
                    Description = "Instant ramen upgraded with vegetables for a quick dinner.",
                    PrepTime = "10 mins",
                    Ingredients = new List<string>
                    {
                        "1 pack ramen noodles",
                        "Mixed vegetables",
                        "Water",
                        "Seasoning packet"
                    },
                    Steps = new List<string>
                    {
                        "Boil water in a pot.",
                        "Add noodles and vegetables.",
                        "Cook until soft.",
                        "Add seasoning and stir.",
                        "Serve hot."
                    }
                },
                new Meal
                {
                    Id = 25,
                    Name = "Mac and Cheese",
                    Category = "Dinner",
                    ImagePath = "mac_cheese.png",
                    Description = "Comfort food that is simple, creamy, and quick.",
                    PrepTime = "12 mins",
                    Ingredients = new List<string>
                    {
                        "Macaroni pasta",
                        "Cheese sauce or shredded cheese",
                        "Milk",
                        "Butter"
                    },
                    Steps = new List<string>
                    {
                        "Cook the macaroni.",
                        "Drain the water.",
                        "Add butter, milk, and cheese.",
                        "Stir until creamy.",
                        "Serve warm."
                    }
                },

                // SNACKS
                new Meal
                {
                    Id = 31,
                    Name = "Yogurt Parfait",
                    Category = "Snacks",
                    ImagePath = "yogurt_parfait.png",
                    Description = "A light snack made with yogurt, fruit, and granola.",
                    PrepTime = "5 mins",
                    Ingredients = new List<string>
                    {
                        "1 cup yogurt",
                        "Granola",
                        "Strawberries",
                        "Honey"
                    },
                    Steps = new List<string>
                    {
                        "Spoon yogurt into a bowl or cup.",
                        "Add granola and strawberries.",
                        "Drizzle with honey.",
                        "Serve chilled."
                    }
                },
                new Meal
                {
                    Id = 32,
                    Name = "Peanut Butter Crackers",
                    Category = "Snacks",
                    ImagePath = "pb_crackers.png",
                    Description = "A very easy snack that takes only minutes to prepare.",
                    PrepTime = "3 mins",
                    Ingredients = new List<string>
                    {
                        "Crackers",
                        "Peanut butter"
                    },
                    Steps = new List<string>
                    {
                        "Spread peanut butter on the crackers.",
                        "Top with another cracker if desired.",
                        "Serve immediately."
                    }
                },
                new Meal
                {
                    Id = 33,
                    Name = "Fruit Cup",
                    Category = "Snacks",
                    ImagePath = "fruit_cup.png",
                    Description = "A refreshing fruit snack made with whatever fruit you have.",
                    PrepTime = "5 mins",
                    Ingredients = new List<string>
                    {
                        "Apple slices",
                        "Banana slices",
                        "Grapes",
                        "Orange pieces"
                    },
                    Steps = new List<string>
                    {
                        "Wash and cut the fruit.",
                        "Place into a bowl or cup.",
                        "Mix gently and serve."
                    }
                },
                new Meal
                {
                    Id = 34,
                    Name = "Cheese and Crackers",
                    Category = "Snacks",
                    ImagePath = "cheese_crackers.png",
                    Description = "A simple snack with cheese and crackers.",
                    PrepTime = "4 mins",
                    Ingredients = new List<string>
                    {
                        "Crackers",
                        "Cheese slices"
                    },
                    Steps = new List<string>
                    {
                        "Place cheese on top of crackers.",
                        "Arrange on a plate.",
                        "Serve immediately."
                    }
                },
                new Meal
                {
                    Id = 35,
                    Name = "Popcorn",
                    Category = "Snacks",
                    ImagePath = "popcorn.png",
                    Description = "A classic snack for studying or movie night.",
                    PrepTime = "5 mins",
                    Ingredients = new List<string>
                    {
                        "Microwave popcorn bag"
                    },
                    Steps = new List<string>
                    {
                        "Place the popcorn bag in the microwave.",
                        "Heat according to package instructions.",
                        "Carefully open and serve."
                    }
                }
            };
        }

        public List<Meal> GetAllMeals()
        {
            return _meals;
        }

        public List<Meal> GetMealsByCategory(string category)
        {
            return _meals
                .Where(m => m.Category.Equals(category, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public Meal? GetMealById(int id)
        {
            return _meals.FirstOrDefault(m => m.Id == id);
        }
    }
}