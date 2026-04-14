import { useCallback, useEffect, useMemo, useState } from "react";
import { Link } from "react-router-dom";
import styles from "./gamepage.module.css";

function GamePage() {
  const [questions, setQuestions] = useState([]);
  const [currentQuestionIndex, setCurrentQuestionIndex] = useState(0);
  const [score, setScore] = useState(0);
  const [isFinished, setIsFinished] = useState(false);
  const [loading, setLoading] = useState(true);
  const [errorMessage, setErrorMessage] = useState("");
  const [playerName, setPlayerName] = useState("");
  const [saveMessage, setSaveMessage] = useState("");
  const [saveError, setSaveError] = useState("");
  const [isSaving, setIsSaving] = useState(false);

  const fetchQuestions = useCallback(async () => {
    setLoading(true);
    setErrorMessage("");

    try {
      const response = await fetch("http://localhost:5026/questions");

      if (!response.ok) {
        throw new Error("Could not fetch questions");
      }

      const data = await response.json();
      setQuestions(data);
      setCurrentQuestionIndex(0);
      setScore(0);
      setIsFinished(false);
    } catch (error) {
      console.error(error);
      setErrorMessage("Something went wrong when fetching the questions.");
    } finally {
      setLoading(false);
    }
  }, []);

  const currentQuestion = questions[currentQuestionIndex];
  const answerOptions = useMemo(
    () =>
      currentQuestion
        ? shuffleAnswers([
            currentQuestion.correctCapital,
            ...currentQuestion.wrongCapitals,
          ])
        : [],
    [currentQuestion],
  );

  useEffect(() => {
    fetchQuestions();
  }, [fetchQuestions]);

  function shuffleAnswers(answers) {
    const shuffledAnswers = [...answers];

    for (let index = shuffledAnswers.length - 1; index > 0; index--) {
      const randomIndex = Math.floor(Math.random() * (index + 1));
      const temporaryValue = shuffledAnswers[index];
      shuffledAnswers[index] = shuffledAnswers[randomIndex];
      shuffledAnswers[randomIndex] = temporaryValue;
    }

    return shuffledAnswers;
  }

  function handleAnswerClick(selectedAnswer) {
    const currentQuestion = questions[currentQuestionIndex];

    if (selectedAnswer === currentQuestion.correctCapital) {
      setScore((previousScore) => previousScore + 1);
    }

    const nextQuestionIndex = currentQuestionIndex + 1;

    if (nextQuestionIndex < questions.length) {
      setCurrentQuestionIndex(nextQuestionIndex);
    } else {
      setIsFinished(true);
    }
  }

  async function handleSaveHighscore() {
    const trimmedName = playerName.trim();

    if (!trimmedName) {
      setSaveError("Please enter a name before saving.");
      return;
    }

    setIsSaving(true);
    setSaveError("");
    setSaveMessage("");

    try {
      const response = await fetch("http://localhost:5026/highscores", {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify({
          name: trimmedName,
          score,
        }),
      });

      if (!response.ok) {
        throw new Error("Could not save highscore");
      }

      setSaveMessage("Highscore saved!");
    } catch (error) {
      console.error(error);
      setSaveError("Could not save the highscore right now.");
    } finally {
      setIsSaving(false);
    }
  }

  function handleRestartGame() {
    setPlayerName("");
    setSaveMessage("");
    setSaveError("");
    fetchQuestions();
  }

  if (loading) {
    return (
      <main className={styles.container}>
        <h1>Loading quiz...</h1>
      </main>
    );
  }

  if (errorMessage) {
    return (
      <main className={styles.container}>
        <h1>Something went wrong</h1>
        <p>{errorMessage}</p>
      </main>
    );
  }

  if (questions.length === 0) {
    return (
      <main className={styles.container}>
        <h1>No questions found</h1>
      </main>
    );
  }

  if (isFinished) {
    return (
      <main className={styles.container}>
        <div className={styles.card}>
          <h1 className={styles.title}>Quiz finished!</h1>
          <p className={styles.finishedText}>
            You got {score} out of {questions.length} correct.
          </p>
          <div className={styles.saveBox}>
            <label className={styles.nameLabel} htmlFor="playerName">
              Name
            </label>
            <input
              id="playerName"
              className={styles.nameInput}
              type="text"
              value={playerName}
              onChange={(event) => setPlayerName(event.target.value)}
              placeholder="Write your name"
              maxLength={20}
            />

            <button
              className={styles.saveButton}
              onClick={handleSaveHighscore}
              disabled={isSaving}
            >
              {isSaving ? "Saving..." : "Save highscore"}
            </button>

            {saveMessage ? (
              <p className={styles.saveMessage}>{saveMessage}</p>
            ) : null}
            {saveError ? <p className={styles.saveError}>{saveError}</p> : null}
          </div>

          <button className={styles.restartButton} onClick={handleRestartGame}>
            New game
          </button>
        </div>
      </main>
    );
  }

  return (
    <main className={styles.container}>
      <div className={styles.card}>
        <div className={styles.headerRow}>
          <Link to="/" className={styles.badgeLink}>
            <span className={styles.badge}>Capital Quiz</span>
          </Link>
          <p className={styles.questionCounter}>
            Question {currentQuestionIndex + 1} of {questions.length}
          </p>
        </div>

        <h1 className={styles.title}>
          What is the capital of {currentQuestion.country}?
        </h1>

        <div className={styles.answersContainer}>
          {answerOptions.map((answer) => (
            <button
              key={answer}
              className={styles.answerButton}
              onClick={() => handleAnswerClick(answer)}
            >
              {answer}
            </button>
          ))}
        </div>

        <div className={styles.footerRow}>
          <p className={styles.score}>Score: {score}</p>
        </div>
      </div>
    </main>
  );
}

export default GamePage;
