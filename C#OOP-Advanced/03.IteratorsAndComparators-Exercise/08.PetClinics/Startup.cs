﻿using System;
using System.Collections.Generic;
using System.Linq;
using _08.PetClinics.Models;

namespace _08.PetClinics
{
    public class Startup
    {
        public static void Main()
        {
            var numberOfCommands = int.Parse(Console.ReadLine());
            var pets = new List<Pet>();
            var clinics = new List<Clinic>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                var tokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var command = tokens[0];
                tokens.Remove(command);

                try
                {
                    switch (command)
                    {
                        case "Create":
                            if (tokens[0] == "Pet")
                            {
                                pets.Add(new Pet(tokens[1], int.Parse(tokens[2]), tokens[3]));
                            }
                            else if (tokens[0] == "Clinic")
                            {
                                clinics.Add(new Clinic(tokens[1], int.Parse(tokens[2])));
                            }
                            break;
                        case "Add":
                            Console.WriteLine(
                                clinics.First(x => x.Name == tokens[1])
                                    .AddPet(pets.First(p => p.Name == tokens[0])));
                            break;
                        case "Release":
                            Console.WriteLine(
                                clinics.First(x => x.Name == tokens[0])
                                    .ReleasePet());
                            break;
                        case "HasEmptyRooms":
                            Console.WriteLine(
                                clinics.First(x => x.Name == tokens[0])
                                    .HasEmptyRooms());
                            break;
                        case "Print":
                            if (tokens.Count == 1)
                            {
                                Console.WriteLine(
                                    clinics.First(x => x.Name == tokens[0])
                                        .Print());
                            }
                            else if (tokens.Count == 2)
                            {
                                Console.WriteLine(
                                    clinics.First(x => x.Name == tokens[0])
                                        .Print(int.Parse(tokens[1])));
                            }
                            break;
                        default:
                            throw new InvalidOperationException("Invalid Operation!");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
