using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace VIPRPrototype.Models
{
    public class VIPRDataInitializer : DropCreateDatabaseAlways<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            new List<Patient>
                {
                    new Patient()
                        {
                            DOB = new DateTime(1975, 1, 15),
                            FirstName = "James",
                            LastName = "Smith",
                            SSNum = "333-22-4444",
                            Address = new Address()
                                {
                                    AddressLine1 = "1234 Main Street",
                                    City = "Nashville",
                                    State = "TN",
                                    Zip = "37028"
                                },
                        },
                    new Patient()
                        {
                            DOB = new DateTime(1970, 4, 22),
                            FirstName = "David",
                            LastName = "Nicolas",
                            SSNum = "433-13-1245",
                            Address = new Address()
                                {
                                    AddressLine1 = "13 Thira Street",
                                    City = "Elk Grove",
                                    State = "CA",
                                    Zip = "95823"
                                },
                        },
                    new Patient()
                        {
                            DOB = new DateTime(1955, 12, 15),
                            FirstName = "Margaret",
                            LastName = "Hiller",
                            SSNum = "323-12-6787",
                            Address = new Address()
                                {
                                    AddressLine1 = "1100 Main Street",
                                    City = "Franklin",
                                    State = "TN",
                                    Zip = "37054"
                                },
                        },
                    new Patient()
                        {
                            DOB = new DateTime(1981, 8, 1),
                            FirstName = "Stacy",
                            LastName = "Wallace",
                            SSNum = "553-32-5644",
                            Address = new Address()
                                {
                                    AddressLine1 = "1800 Poppy Drive",
                                    City = "Rancho Cordova",
                                    State = "CA",
                                    Zip = "95633"
                                },
                        }
                }.ForEach(p => context.Patients.Add(p));
            context.SaveChanges();

            new List<Provider>
                {
                    new Provider()
                        {
                            FirstName = "Victor",
                            LastName = "Ola",
                            Title = "MD"
                        },
                    new Provider()
                        {
                            FirstName = "Tony",
                            LastName = "RadCliffe",
                            Title = "MD"
                        },
                    new Provider()
                        {
                            FirstName = "Maria",
                            LastName = "Gonsalez",
                            Title = "MD"
                        },
                    new Provider()
                        {
                            FirstName = "Susan",
                            LastName = "Kim",
                            Title = "MD"
                        },
                    new Provider()
                        {
                            FirstName = "Kelly",
                            LastName = "Martin",
                            Title = "PA"
                        },
                }.ForEach(p => context.Providers.Add(p));
            context.SaveChanges();

            new List<Chart>
                {
                    new Chart()
                        {
                            PatientId = 1,
                            CreateOnDate = new DateTime(1999, 5, 20),
                            Encounters = new List<Encounter>
                                {
                                    new Encounter()
                                        {
                                            ProviderId = 2,
                                            VisitTime = new DateTime(1999, 5, 20, 10, 0, 0),
                                            Title = "Nausia, Dizziness, Foot Pain",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 2,
                                            VisitTime = new DateTime(2000, 1, 5, 13, 0, 0),
                                            Title = "Foot Pain",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 5,
                                            VisitTime = new DateTime(2000, 6, 25, 8, 0, 0),
                                            Title = "Chest Pain",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 5,
                                            VisitTime = new DateTime(2000, 6, 25, 9, 30, 0),
                                            Title = "Chest X-Ray",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 2,
                                            VisitTime = new DateTime(2000, 1, 5, 13, 0, 0),
                                            Title = "Foot Pain",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 5,
                                            VisitTime = new DateTime(2000, 6, 25, 8, 0, 0),
                                            Title = "Chest Pain",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 5,
                                            VisitTime = new DateTime(2000, 6, 25, 9, 30, 0),
                                            Title = "Chest X-Ray",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 2,
                                            VisitTime = new DateTime(2000, 1, 5, 13, 0, 0),
                                            Title = "Foot Pain",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 5,
                                            VisitTime = new DateTime(2000, 6, 25, 8, 0, 0),
                                            Title = "Chest Pain",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 5,
                                            VisitTime = new DateTime(2000, 6, 25, 9, 30, 0),
                                            Title = "Chest X-Ray",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 2,
                                            VisitTime = new DateTime(2000, 1, 5, 13, 0, 0),
                                            Title = "Foot Pain",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 5,
                                            VisitTime = new DateTime(2000, 6, 25, 8, 0, 0),
                                            Title = "Chest Pain",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 5,
                                            VisitTime = new DateTime(2000, 6, 25, 9, 30, 0),
                                            Title = "Chest X-Ray",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 2,
                                            VisitTime = new DateTime(2000, 1, 5, 13, 0, 0),
                                            Title = "Foot Pain",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 5,
                                            VisitTime = new DateTime(2000, 6, 25, 8, 0, 0),
                                            Title = "Chest Pain",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 5,
                                            VisitTime = new DateTime(2000, 6, 25, 9, 30, 0),
                                            Title = "Chest X-Ray",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 2,
                                            VisitTime = new DateTime(2000, 1, 5, 13, 0, 0),
                                            Title = "Foot Pain",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 5,
                                            VisitTime = new DateTime(2000, 6, 25, 8, 0, 0),
                                            Title = "Chest Pain",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 5,
                                            VisitTime = new DateTime(2000, 6, 25, 9, 30, 0),
                                            Title = "Chest X-Ray",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 2,
                                            VisitTime = new DateTime(2000, 1, 5, 13, 0, 0),
                                            Title = "Foot Pain",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 5,
                                            VisitTime = new DateTime(2000, 6, 25, 8, 0, 0),
                                            Title = "Chest Pain",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 5,
                                            VisitTime = new DateTime(2000, 6, 25, 9, 30, 0),
                                            Title = "Chest X-Ray",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 2,
                                            VisitTime = new DateTime(2000, 1, 5, 13, 0, 0),
                                            Title = "Foot Pain",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 5,
                                            VisitTime = new DateTime(2000, 6, 25, 8, 0, 0),
                                            Title = "Chest Pain",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 5,
                                            VisitTime = new DateTime(2000, 6, 25, 9, 30, 0),
                                            Title = "Chest X-Ray",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 2,
                                            VisitTime = new DateTime(2000, 1, 5, 13, 0, 0),
                                            Title = "Foot Pain",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 5,
                                            VisitTime = new DateTime(2000, 6, 25, 8, 0, 0),
                                            Title = "Chest Pain",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 5,
                                            VisitTime = new DateTime(2000, 6, 25, 9, 30, 0),
                                            Title = "Chest X-Ray",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 2,
                                            VisitTime = new DateTime(2000, 1, 5, 13, 0, 0),
                                            Title = "Foot Pain",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 5,
                                            VisitTime = new DateTime(2000, 6, 25, 8, 0, 0),
                                            Title = "Chest Pain",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 5,
                                            VisitTime = new DateTime(2000, 6, 25, 9, 30, 0),
                                            Title = "Chest X-Ray",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 2,
                                            VisitTime = new DateTime(2000, 1, 5, 13, 0, 0),
                                            Title = "Foot Pain",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 5,
                                            VisitTime = new DateTime(2000, 6, 25, 8, 0, 0),
                                            Title = "Chest Pain",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 5,
                                            VisitTime = new DateTime(2000, 6, 25, 9, 30, 0),
                                            Title = "Chest X-Ray",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 2,
                                            VisitTime = new DateTime(2000, 1, 5, 13, 0, 0),
                                            Title = "Foot Pain",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 5,
                                            VisitTime = new DateTime(2000, 6, 25, 8, 0, 0),
                                            Title = "Chest Pain",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 5,
                                            VisitTime = new DateTime(2000, 6, 25, 9, 30, 0),
                                            Title = "Chest X-Ray",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 2,
                                            VisitTime = new DateTime(2000, 1, 5, 13, 0, 0),
                                            Title = "Foot Pain",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 5,
                                            VisitTime = new DateTime(2000, 6, 25, 8, 0, 0),
                                            Title = "Chest Pain",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 5,
                                            VisitTime = new DateTime(2000, 6, 25, 9, 30, 0),
                                            Title = "Chest X-Ray",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 2,
                                            VisitTime = new DateTime(2000, 1, 5, 13, 0, 0),
                                            Title = "Foot Pain",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 5,
                                            VisitTime = new DateTime(2000, 6, 25, 8, 0, 0),
                                            Title = "Chest Pain",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 5,
                                            VisitTime = new DateTime(2000, 6, 25, 9, 30, 0),
                                            Title = "Chest X-Ray",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 2,
                                            VisitTime = new DateTime(2000, 1, 5, 13, 0, 0),
                                            Title = "Foot Pain",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 5,
                                            VisitTime = new DateTime(2000, 6, 25, 8, 0, 0),
                                            Title = "Chest Pain",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 5,
                                            VisitTime = new DateTime(2000, 6, 25, 9, 30, 0),
                                            Title = "Chest X-Ray",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 2,
                                            VisitTime = new DateTime(2000, 1, 5, 13, 0, 0),
                                            Title = "Foot Pain",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        }
                                }

                        },
                    new Chart()
                        {
                            PatientId = 2,
                            CreateOnDate = new DateTime(2005, 3, 1),
                            Encounters = new List<Encounter>
                                {
                                    new Encounter()
                                        {
                                            ProviderId = 5,
                                            VisitTime = new DateTime(2000, 6, 25, 8, 0, 0),
                                            Title = "Chest Pain",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 5,
                                            VisitTime = new DateTime(2000, 6, 25, 9, 30, 0),
                                            Title = "Chest X-Ray",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 2,
                                            VisitTime = new DateTime(2000, 1, 5, 13, 0, 0),
                                            Title = "Foot Pain",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 5,
                                            VisitTime = new DateTime(2000, 6, 25, 8, 0, 0),
                                            Title = "Chest Pain",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 5,
                                            VisitTime = new DateTime(2000, 6, 25, 9, 30, 0),
                                            Title = "Dizziness, Headache",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 2,
                                            VisitTime = new DateTime(2000, 1, 5, 13, 0, 0),
                                            Title = "Foot Pain",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        }
                                }
                        },
                    new Chart()
                        {
                            PatientId = 3,
                            CreateOnDate = new DateTime(2006, 8, 1),
                            Encounters = new List<Encounter>
                                {
                                    
                                    new Encounter()
                                        {
                                            ProviderId = 5,
                                            VisitTime = new DateTime(2000, 6, 25, 8, 0, 0),
                                            Title = "Chest Pain",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 5,
                                            VisitTime = new DateTime(2000, 6, 25, 9, 30, 0),
                                            Title = "Chest X-Ray",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        },
                                    new Encounter()
                                        {
                                            ProviderId = 5,
                                            VisitTime = new DateTime(2000, 6, 25, 9, 30, 0),
                                            Title = "Chest X-Ray",
                                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque in nibh lorem. Suspendisse potenti. Pellentesque eu risus massa, eu vulputate metus. Cras eu consectetur nunc. Etiam gravida, diam a volutpat blandit, enim augue ullamcorper augue, ut pharetra elit eros sit amet leo. Curabitur fermentum, tellus in volutpat vehicula, est risus volutpat ipsum, vel cursus ante tellus ac ligula. Cras risus risus, fermentum ac convallis quis, mattis non urna. Mauris elit libero, vulputate in posuere sit amet, pellentesque sit amet lorem. Donec iaculis purus lacus, quis commodo nulla. Mauris semper rhoncus nisi, eu mattis neque mollis eu. Cras neque sem, lacinia vel lacinia in, malesuada a lorem. Nam molestie lobortis bibendum."
                                        }
                                }
                        }
                }.ForEach(c => context.Charts.Add(c));
            context.SaveChanges();

            base.Seed(context);
        }
    }
}