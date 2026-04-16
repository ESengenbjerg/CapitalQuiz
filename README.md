# Capital Quiz API

This is the backend for a quiz application built with **C# / ASP.NET Core**.  
It provides quiz questions and handles highscores for a React frontend.

---

## Features

- Get random quiz questions
- Save player highscores
- Retrieve top highscores
- Simple file-based storage (no database)

---

## Tech Stack

- ASP.NET Core (.NET 9)
- Minimal API
- Docker
- Render (deployment)

---

## Endpoints

### Get random questions

GET /questions

Returns 10 random quiz questions.

---

### Get highscores

GET /highscores

Returns a list of highscores.

---

### Save highscore

POST /highscores

Body example:

```json
{
  "name": "Daniella",
  "score": 8
}
```
