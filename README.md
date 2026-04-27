



Dorm Chef

Dorm Chef is a simple mobile recipe application built with .NET MAUI. The app is designed to help college students and beginner cooks quickly find easy meals that are affordable, simple, and practical for everyday use.

Project Goals

The main goal of Dorm Chef is to provide a clean and easy-to-use cooking app for users who may not have much time, cooking experience, or access to many ingredients.

The app focuses on:

Simple meal discovery

Easy to make food recipes

Categories to browse ( Breakfast, Lunch, Dinner, Snacks )

Favourites are saved locally on the device. 

You can access the app without needing an account or to log in.



Main Features

Home screen with meal categories

Breakfast, Lunch, Dinner, and Snacks sections

Recipe detail pages that have the picture of the food, time to cook, ingredients, and instructions

Favorites button to access saved meals

SQLite local storage for favorites and profile data



Technologies Used

.NET MAUI

C#

XAML

MVVM architecture

SQLite local database

Visual Studio



NuGet Packages

sqlite-net-pcl
Used for local database storage.

SQLitePCLRaw.bundle_green
Required to support SQLite functionality.



How to Build and Run the App

in other to build this app, you need:

Visual Studio 2022 or later

.NET MAUI workload is installed

Android emulator or physical Android device

.NET 8 SDK



Steps / Procedure

Clone the repository:



git clone https://github.com/Ernest40/DormChef.git



Open the solution file in Visual Studio.

Restore NuGet packages if needed:

dotnet restore



Select an Android emulator or connected device.

Build the solution:

dotnet build



Run the app from Visual Studio by clicking the Run button.



Notes about the images;

Make sure that all the images for the app are stored in the directory:

Resources/Images



Also, the names of the image files must match those used in the meal data service.



Ernest Ackah
