import styles from "./startpage.module.css";
import { useNavigate } from "react-router-dom";

function StartPage() {
  const navigate = useNavigate();

  function handleNewGame() {
    navigate("/game");
  }

  return (
    <main className={styles.container}>
      <h1>Welcome to the Capital Quiz!</h1>

      <button onClick={handleNewGame}>New game</button>
    </main>
  );
}

export default StartPage;
