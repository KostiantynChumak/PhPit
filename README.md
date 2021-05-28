# Witryna z listą studentów



## Table of Contents
* [General Info](#general-information)
* [Technologies Used](#technologies-used)
* [Features](#features)
* [Screenshots](#screenshots)
* [Setup](#setup)
* [Usage](#usage)
* [Project Status](#project-status)
* [Room for Improvement](#room-for-improvement)
* [Contact](#contact)
<!-- * [License](#license) -->


## General Information
- Witryna z listą studentów. Umożliwia wprowadzenie danych studentów do przetwarzania i przechowywania informacji.
<!-- You don't have to answer all the questions - just the ones relevant to your project. -->


## Technologies Used
- C#
- HTML
- Blazor
- Crud
- MongoBD


## Features
List the ready features here:
- Dodawać studentów 
- Edytować i usuwać dane studentów
- Dane są przechowywane w bazie danych MongoDB


## Screenshots


![Screenshot_4](https://user-images.githubusercontent.com/60564197/119940834-72fc3e80-bf98-11eb-8af0-b278a6905303.png)



<!-- If you have screenshots you'd like to share, include them here. -->


## Setup

Aby otworzyć projekt, potrzebujesz:
- Pobierz sam projekt z Github
- Otwórz MongoDB i dodaj adres
- Uruchomić projekt 




## Usage

{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }


## Project Status
__Projekt zakończony.
Jestem zaangażowany w następujące projekty.__

## Room for Improvement

Room for improvement:
- Dodać dodatkowe informacje dla studentów
- Możliwość rejestracji i autoryzacji 
- Dodać harmonogram 





## Contact
 [![Telegram](https://img.shields.io/badge/-Telegram-1F022C?style=for-the-badge&logo=telegram&logoColor=35ACE4)](https://t.me/idudos)
 
 

 [![LinkedIn](https://img.shields.io/badge/-LinkedIn-1F022C?style=for-the-badge&logo=linkedin&logoColor=35ACE4)](https://www.linkedin.com/in/kostiantyn-chumak-98097b1a7/)
 
 

   
    + E-mail: kostiantynchumak@gmail.com



<!-- Optional -->
<!-- ## License -->
<!-- This project is open source and available under the [... License](). -->

<!-- You don't have to include all sections - just the one's relevant to your project -->
