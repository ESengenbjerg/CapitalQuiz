import { useEffect, useState } from "react";
import styles from "./gamepage.module.css";

function GamePage() {
  const [questions, setQuestions] = useState([]);
  const [currentQuestionIndex, setCurrentQuestionIndex] = useState(0);
  const [score, setScore] = useState(0);
  const [isFinished, setIsFinished] = useState(false);
  const [loading, setLoading] = useState(true);
  const [errorMessage, setErrorMessage] = useState("");

  useEffect(() => {
    async function fetchQuestions() {
      try {
        const response = await fetch("http://localhost:5026/questions");

        if (!response.ok) {
          throw new Error("Could not fetch questions");
        }

        const data = await response.json();
        setQuestions(data);
      } catch (error) {
        console.error(error);
        setErrorMessage("Something went wrong when fetching the questions.");
      } finally {
        setLoading(false);
      }
    }

    fetchQuestions();
  }, []);

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
        <h1>Quiz finished!</h1>
        <p>
          You got {score} out of {questions.length} correct.
        </p>
      </main>
    );
  }

  const currentQuestion = questions[currentQuestionIndex];
  const answerOptions = shuffleAnswers([
    currentQuestion.correctCapital,
    ...currentQuestion.wrongCapitals,
  ]);

  return (
    <main className={styles.container}>
      <h1>Capital Quiz</h1>

      <p className={styles.questionCounter}>
        Question {currentQuestionIndex + 1} of {questions.length}
      </p>

      <h2 className={styles.question}>
        What is the capital of {currentQuestion.country}?
      </h2>

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

      <p className={styles.score}>Score: {score}</p>
    </main>
  );
}

export default GamePage;
