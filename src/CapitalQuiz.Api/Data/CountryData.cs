using CapitalQuiz.Api.Models;

namespace CapitalQuiz.Api.Data;

public static class CountryData
{
    public static List<CountryQuestion> GetAll()
    {
        return new List<CountryQuestion>
        {
            new CountryQuestion
            {
                 Country = "Sweden",
                 CorrectCapital = "Stockholm",
                 WrongCapitals = new List<string> { "Oslo", "Copenhagen", "Helsinki" }
            },
            new CountryQuestion
            {
                Country = "Norway",
                CorrectCapital = "Oslo",
                WrongCapitals = new List<string> { "Bergen", "Trondheim", "Copenhagen" }
            },
            new CountryQuestion
            {
                Country = "Denmark",
                CorrectCapital = "Copenhagen",
                WrongCapitals = new List<string> { "Aarhus", "Oslo", "Stockholm" }
            },
            new CountryQuestion
            {
                Country = "Finland",
                CorrectCapital = "Helsinki",
                WrongCapitals = new List<string> { "Tampere", "Tallinn", "Stockholm" }
            },
            new CountryQuestion
            {
                Country = "Iceland",
                CorrectCapital = "Reykjavik",
                WrongCapitals = new List<string> { "Oslo", "Helsinki", "Nuuk" }
            },
            new CountryQuestion
            {
                Country = "Germany",
                CorrectCapital = "Berlin",
                WrongCapitals = new List<string> { "Munich", "Hamburg", "Frankfurt" }
            },
            new CountryQuestion
            {
                Country = "France",
                CorrectCapital = "Paris",
                WrongCapitals = new List<string> { "Lyon", "Marseille", "Nice" }
            },
            new CountryQuestion
            {
                Country = "Spain",
                CorrectCapital = "Madrid",
                WrongCapitals = new List<string> { "Barcelona", "Valencia", "Seville" }
            },
            new CountryQuestion
            {
                Country = "Italy",
                CorrectCapital = "Rome",
                WrongCapitals = new List<string> { "Milan", "Florence", "Naples" }
            },
            new CountryQuestion
            {
                Country = "Portugal",
                CorrectCapital = "Lisbon",
                WrongCapitals = new List<string> { "Porto", "Madrid", "Faro" }
            },
            new CountryQuestion
            {
                Country = "United Kingdom",
                CorrectCapital = "London",
                WrongCapitals = new List<string> { "Manchester", "Edinburgh", "Birmingham" }
            },
            new CountryQuestion
            {
                Country = "Ireland",
                CorrectCapital = "Dublin",
                WrongCapitals = new List<string> { "Cork", "Belfast", "Galway" }
            },
            new CountryQuestion
            {
                Country = "Netherlands",
                CorrectCapital = "Amsterdam",
                WrongCapitals = new List<string> { "Rotterdam", "The Hague", "Utrecht" }
            },
            new CountryQuestion
            {
                Country = "Belgium",
                CorrectCapital = "Brussels",
                WrongCapitals = new List<string> { "Antwerp", "Ghent", "Bruges" }
            },
            new CountryQuestion
            {
                Country = "Switzerland",
                CorrectCapital = "Bern",
                WrongCapitals = new List<string> { "Zurich", "Geneva", "Basel" }
            },
            new CountryQuestion
            {
                Country = "Austria",
                CorrectCapital = "Vienna",
                WrongCapitals = new List<string> { "Salzburg", "Graz", "Innsbruck" }
            },
            new CountryQuestion
            {
                Country = "Poland",
                CorrectCapital = "Warsaw",
                WrongCapitals = new List<string> { "Krakow", "Gdansk", "Wroclaw" }
            },
            new CountryQuestion
            {
                Country = "Czech Republic",
                CorrectCapital = "Prague",
                WrongCapitals = new List<string> { "Brno", "Vienna", "Budapest" }
            },
            new CountryQuestion
            {
                Country = "Hungary",
                CorrectCapital = "Budapest",
                WrongCapitals = new List<string> { "Debrecen", "Prague", "Bratislava" }
            },
            new CountryQuestion
            {
                Country = "Greece",
                CorrectCapital = "Athens",
                WrongCapitals = new List<string> { "Thessaloniki", "Heraklion", "Sofia" }
            },
            new CountryQuestion
            {
                Country = "Turkey",
                CorrectCapital = "Ankara",
                WrongCapitals = new List<string> { "Istanbul", "Izmir", "Bursa" }
            },
            new CountryQuestion
            {
                Country = "Russia",
                CorrectCapital = "Moscow",
                WrongCapitals = new List<string> { "Saint Petersburg", "Kazan", "Sochi" }
            },
            new CountryQuestion
            {
                Country = "United States",
                CorrectCapital = "Washington, D.C.",
                WrongCapitals = new List<string> { "New York", "Los Angeles", "Chicago" }
            },
            new CountryQuestion
            {
                Country = "Canada",
                CorrectCapital = "Ottawa",
                WrongCapitals = new List<string> { "Toronto", "Vancouver", "Montreal" }
            },
            new CountryQuestion
            {
                Country = "Mexico",
                CorrectCapital = "Mexico City",
                WrongCapitals = new List<string> { "Guadalajara", "Monterrey", "Cancun" }
            },
            new CountryQuestion
            {
                Country = "Brazil",
                CorrectCapital = "Brasilia",
                WrongCapitals = new List<string> { "Rio de Janeiro", "São Paulo", "Salvador" }
            },
            new CountryQuestion
            {
                Country = "Argentina",
                CorrectCapital = "Buenos Aires",
                WrongCapitals = new List<string> { "Córdoba", "Rosario", "Mendoza" }
            },
            new CountryQuestion
            {
                Country = "Japan",
                CorrectCapital = "Tokyo",
                WrongCapitals = new List<string> { "Osaka", "Kyoto", "Nagoya" }
            },
            new CountryQuestion
            {
                Country = "China",
                CorrectCapital = "Beijing",
                WrongCapitals = new List<string> { "Shanghai", "Guangzhou", "Shenzhen" }
            },
            new CountryQuestion
            {
                Country = "Australia",
                CorrectCapital = "Canberra",
                WrongCapitals = new List<string> { "Sydney", "Melbourne", "Brisbane" }
            },
            new CountryQuestion
            {
                Country = "New Zealand",
                CorrectCapital = "Wellington",
                WrongCapitals = new List<string> { "Auckland", "Christchurch", "Hamilton" }
            },
            new CountryQuestion
            {
                Country = "South Korea",
                CorrectCapital = "Seoul",
                WrongCapitals = new List<string> { "Busan", "Incheon", "Daegu" }
            },
            new CountryQuestion
            {
                Country = "North Korea",
                CorrectCapital = "Pyongyang",
                WrongCapitals = new List<string> { "Hamhung", "Wonsan", "Kaesong" }
            },
            new CountryQuestion
            {
                Country = "India",
                CorrectCapital = "New Delhi",
                WrongCapitals = new List<string> { "Mumbai", "Bangalore", "Kolkata" }
            },
            new CountryQuestion
            {
                Country = "Pakistan",
                CorrectCapital = "Islamabad",
                WrongCapitals = new List<string> { "Karachi", "Lahore", "Rawalpindi" }
            },
            new CountryQuestion
            {
                Country = "Bangladesh",
                CorrectCapital = "Dhaka",
                WrongCapitals = new List<string> { "Chittagong", "Khulna", "Sylhet" }
            },
            new CountryQuestion
            {
                Country = "Sri Lanka",
                CorrectCapital = "Sri Jayawardenepura Kotte",
                WrongCapitals = new List<string> { "Colombo", "Galle", "Kandy" }
            },
            new CountryQuestion
            {
                Country = "Nepal",
                CorrectCapital = "Kathmandu",
                WrongCapitals = new List<string> { "Pokhara", "Lalitpur", "Biratnagar" }
            },
            new CountryQuestion
            {
                Country = "Thailand",
                CorrectCapital = "Bangkok",
                WrongCapitals = new List<string> { "Chiang Mai", "Phuket", "Pattaya" }
            },
            new CountryQuestion
            {
                Country = "Vietnam",
                CorrectCapital = "Hanoi",
                WrongCapitals = new List<string> { "Ho Chi Minh City", "Da Nang", "Hue" }
            },
            new CountryQuestion
            {
                Country = "Indonesia",
                CorrectCapital = "Jakarta",
                WrongCapitals = new List<string> { "Surabaya", "Bandung", "Medan" }
            },
            new CountryQuestion
            {
                Country = "Philippines",
                CorrectCapital = "Manila",
                WrongCapitals = new List<string> { "Cebu", "Davao", "Quezon City" }
            },
            new CountryQuestion
            {
                Country = "South Africa",
                CorrectCapital = "Pretoria",
                WrongCapitals = new List<string> { "Cape Town", "Johannesburg", "Durban" }
            },
            new CountryQuestion
            {
                Country = "Egypt",
                CorrectCapital = "Cairo",
                WrongCapitals = new List<string> { "Alexandria", "Giza", "Luxor" }
            },
            new CountryQuestion
            {
                Country = "Nigeria",
                CorrectCapital = "Abuja",
                WrongCapitals = new List<string> { "Lagos", "Kano", "Ibadan" }
            },
            new CountryQuestion
            {
                Country = "Kenya",
                CorrectCapital = "Nairobi",
                WrongCapitals = new List<string> { "Mombasa", "Kisumu", "Nakuru" }
            },
            new CountryQuestion
            {
                Country = "Ethiopia",
                CorrectCapital = "Addis Ababa",
                WrongCapitals = new List<string> { "Gondar", "Mekelle", "Dire Dawa" }
            },
            new CountryQuestion
            {
                Country = "Saudi Arabia",
                CorrectCapital = "Riyadh",
                WrongCapitals = new List<string> { "Jeddah", "Mecca", "Medina" }
            },
            new CountryQuestion
            {
                Country = "United Arab Emirates",
                CorrectCapital = "Abu Dhabi",
                WrongCapitals = new List<string> { "Dubai", "Sharjah", "Al Ain" }
            },
            new CountryQuestion
            {
                Country = "Iran",
                CorrectCapital = "Tehran",
                WrongCapitals = new List<string> { "Mashhad", "Isfahan", "Shiraz" }
            },
            new CountryQuestion
            {
                Country = "Israel",
                CorrectCapital = "Jerusalem",
                WrongCapitals = new List<string> { "Tel Aviv", "Haifa", "Eilat" }
            },
            new CountryQuestion
            {
                Country = "Chile",
                CorrectCapital = "Santiago",
                WrongCapitals = new List<string> { "Valparaíso", "Concepción", "Antofagasta" }
            },
            new CountryQuestion
            {
                Country = "Peru",
                CorrectCapital = "Lima",
                WrongCapitals = new List<string> { "Cusco", "Arequipa", "Trujillo" }
            },
            new CountryQuestion
            {
                Country = "Colombia",
                CorrectCapital = "Bogotá",
                WrongCapitals = new List<string> { "Medellín", "Cali", "Barranquilla" }
            },
            new CountryQuestion
            {
                Country = "Venezuela",
                CorrectCapital = "Caracas",
                WrongCapitals = new List<string> { "Maracaibo", "Valencia", "Barquisimeto" }
            },
            new CountryQuestion
            {
                Country = "South Sudan",
                CorrectCapital = "Juba",
                WrongCapitals = new List<string> { "Malakal", "Wau", "Bor" }
            },
            new CountryQuestion
            {
                Country = "Morocco",
                CorrectCapital = "Rabat",
                WrongCapitals = new List<string> { "Casablanca", "Marrakech", "Fes" }
            },
            new CountryQuestion
            {
                Country = "Algeria",
                CorrectCapital = "Algiers",
                WrongCapitals = new List<string> { "Oran", "Constantine", "Annaba" }
            },
            new CountryQuestion
            {
                Country = "Tunisia",
                CorrectCapital = "Tunis",
                WrongCapitals = new List<string> { "Sfax", "Sousse", "Bizerte" }
            },
            new CountryQuestion
            {
                Country = "Singapore",
                CorrectCapital = "Singapore",
                WrongCapitals = new List<string> { "Johor Bahru", "Kuala Lumpur", "Batam" }
            }

        };
    }
}