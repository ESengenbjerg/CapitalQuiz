// import { useState } from "react";
// import reactLogo from "./assets/react.svg";
// import viteLogo from "./assets/vite.svg";
// import heroImg from "./assets/hero.png";
import StartPage from "./pages/startpage";
import GamePage from "./pages/gamepage";
import "./App.css";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";

function App() {
  // const [count, setCount] = useState(0);

  return (
    <>
      <Router>
        <Routes>
          <Route path="/" element={<StartPage />} />
          <Route path="/game" element={<GamePage />} />
        </Routes>
      </Router>
    </>
  );
}

export default App;
