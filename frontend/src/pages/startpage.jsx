import styles from "./startpage.module.css";
import { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";

function StartPage() {
  const [scores, setScores] = useState([]);
  const navigate = useNavigate();

  useEffect(() => {
    fetch("http://localhost:5026/highscores")
      .then((res) => res.json())
      .then((data) => setScores(data));
  }, []);

  function handleNewGame() {
    navigate("/game");
  }

  return (
    <main className={styles.container}>
      <h1>Welcome to the Capital Quiz!</h1>

        {/* This page only needs to redirect to gamepage. Backend starts the actual game logic */}
        <button onClick={handleNewGame}>New game</button>

        <section>
          <h2>Highscores</h2>
          <ol>
            {scores.map((score, i) => (
              <li key={i}>
                {score.name}: {score.score}
              </li>
            ))}
          </ol>
        </section>
      </main>
    </>
  );
}

export default StartPage;
