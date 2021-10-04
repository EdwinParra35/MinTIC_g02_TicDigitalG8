using MovieProject.Shared.Entity;
using System.Collections.Generic;
using System;
namespace MovieProject.Client.Services
{
    public class ServiceActor: IServiceActor
    {
        public List <Actor> GetActors(){
            return new List<Actor>{
                new Actor(){ActorName = "Will Smith", DocumentType=DocumentType.CedulaCiudadana,Document="105381142",Gender = Gender.Masculino,BirthDate= new DateTime(1990,12,03),KnowCredits=12, Nominations = 3,Biography="Biografía...", Photo="/Images/Actors/actor1.jpg"},
                new Actor(){ActorName = "Actor 1", DocumentType=DocumentType.CedulaCiudadana,Document="105381142",Gender = Gender.Masculino,BirthDate= new DateTime(1990,12,03),KnowCredits=12, Nominations = 3,Biography="Biografía...", Photo="/Images/Actors/actor2.jpg"},
                new Actor(){ActorName = "Actor 1", DocumentType=DocumentType.CedulaExtranjera,Document="105381142",Gender = Gender.Masculino,BirthDate= new DateTime(1990,12,03),KnowCredits=12, Nominations = 3,Biography="Biografía...", Photo="/Images/Actors/actor3.jpg"},
                new Actor(){ActorName = "Actor 1", DocumentType=DocumentType.CedulaCiudadana,Document="105381142",Gender = Gender.Masculino,BirthDate= new DateTime(1990,12,03),KnowCredits=12, Nominations = 3,Biography="Biografía...", Photo="/Images/Actors/actor4.jpg"},
                new Actor(){ActorName = "Actor 1", DocumentType=DocumentType.CedulaCiudadana,Document="105381142",Gender = Gender.Masculino,BirthDate= new DateTime(1990,12,03),KnowCredits=12, Nominations = 3,Biography="Biografía...", Photo="/Images/Actors/actor5.jpg"},
                new Actor(){ActorName = "Actor 1", DocumentType=DocumentType.CedulaCiudadana,Document="105381142",Gender = Gender.Masculino,BirthDate= new DateTime(1990,12,03),KnowCredits=12, Nominations = 3,Biography="Biografía...", Photo="/Images/Actors/actor6.jpg"},
                new Actor(){ActorName = "Actor 1", DocumentType=DocumentType.CedulaExtranjera,Document="105381142",Gender = Gender.Masculino,BirthDate= new DateTime(1990,12,03),KnowCredits=12, Nominations = 3,Biography="Biografía...", Photo="/Images/Actors/actor7.jpg"},
                new Actor(){ActorName = "Actor 1", DocumentType=DocumentType.CedulaCiudadana,Document="105381142",Gender = Gender.Masculino,BirthDate= new DateTime(1990,12,03),KnowCredits=12, Nominations = 3,Biography="Biografía...", Photo="/Images/Actors/actor8.jpg"},
                new Actor(){ActorName = "Actor 1", DocumentType=DocumentType.CedulaCiudadana,Document="105381142",Gender = Gender.Masculino,BirthDate= new DateTime(1990,12,03),KnowCredits=12, Nominations = 3,Biography="Biografía...", Photo="/Images/Actors/actor9.jpg"},
                new Actor(){ActorName = "Actor 1", DocumentType=DocumentType.CedulaCiudadana,Document="105381142",Gender = Gender.Masculino,BirthDate= new DateTime(1990,12,03),KnowCredits=12, Nominations = 3,Biography="Biografía...", Photo="/Images/Actors/actor10.jpg"}
            };
        }
    }
}