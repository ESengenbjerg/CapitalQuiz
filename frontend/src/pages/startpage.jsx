import styles from "./startpage.module.css";
import { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";

function StartPage() {
  const [scores, setScores] = useState([]);
  const [loadingScores, setLoadingScores] = useState(true);
  const [scoresError, setScoresError] = useState("");
  const navigate = useNavigate();

  useEffect(() => {
    async function fetchHighscores() {
      try {
        setLoadingScores(true);
        setScoresError("");

        const response = await fetch(
          "https://capitalquizbackend.onrender.com/highscores",
        );

        if (!response.ok) {
          throw new Error("Could not fetch highscores");
        }

        const data = await response.json();
        setScores(data);
      } catch (error) {
        console.error(error);
        setScoresError("Could not load highscores.");
      } finally {
        setLoadingScores(false);
      }
    }

    fetchHighscores();
  }, []);

  function handleNewGame() {
    navigate("/game");
  }

  return (
    <main className={styles.container}>
      <div className={styles.pageHeader}>
        <h1 className={styles.pageTitle}>Capital Quiz</h1>
        <p className={styles.pageSubtitle}>Can you beat the highscores?</p>
      </div>

      <div className={styles.card}>
        <section className={styles.highscoreSection}>
          <h2>Highscores</h2>
          {loadingScores ? (
            <p>Loading highscores...</p>
          ) : scoresError ? (
            <p>{scoresError}</p>
          ) : scores.length === 0 ? (
            <p>No highscores yet.</p>
          ) : (
            <ol className={styles.highscoreList}>
              {scores.map((score) => (
                <li key={score.name}>
                  <span className={styles.highscoreName}>{score.name}</span>
                  <span className={styles.highscoreScore}>{score.score}</span>
                </li>
              ))}
            </ol>
          )}
        </section>

        {/* This page only needs to redirect to gamepage. Backend starts the actual game logic */}
        <button className={styles.newGameButton} onClick={handleNewGame}>
          New game
        </button>
      </div>
    </main>
  );
}

export default StartPage;
