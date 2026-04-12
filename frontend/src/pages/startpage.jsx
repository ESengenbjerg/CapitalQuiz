import styles from "./startpage.module.css";
import { useNavigate } from "react-router-dom";

function StartPage() {
  // const [count, setCount] = useState(0);
  const navigate = useNavigate();

  function handleNewGame() {
    navigate("/game");
  }

  return (
    <>
      <main>
        <h1>Welcome to the Capital Quiz!</h1>

        {/* This page only needs to redirect to gamepage. Backend starts the actual game logic */}
        <button onClick={handleNewGame}>New game</button>
      </main>
    </>
  );
}

export default StartPage;
