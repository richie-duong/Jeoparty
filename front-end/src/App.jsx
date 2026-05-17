import { useEffect, useState } from "react";
import axios from "axios";

function App() {
  const [questions, setQuestions] = useState([]);
  const [score, setScore] = useState(0);

  useEffect(() => {
    fetchQuestions();
  }, []);

  async function fetchQuestions() {
    try {
      const response = await axios.get(
        "http://localhost:5229/api/questions"
      );

      setQuestions(response.data);
    } catch (error) {
      console.error(error);
    }
  }

  function handleQuestionClick(question) {
    alert(
      `${question.prompt}\n\nAnswer: ${question.answer}`
    );

    setScore(score + question.value);
  }

  return (
    <div className="min-h-screen bg-blue-950 text-white p-10">
      <h1 className="text-5xl font-bold text-center mb-8">
        Jeoparty
      </h1>

      <h2 className="text-3xl text-center mb-10">
        Score: {score}
      </h2>

      <div className="grid grid-cols-4 gap-6">
        {questions.map((question) => (
          <button
            key={question.id}
            onClick={() => handleQuestionClick(question)}
            className="
              bg-blue-700
              hover:bg-blue-600
              rounded-xl
              p-10
              text-4xl
              font-bold
              shadow-lg
              transition
            "
          >
            ${question.value}
          </button>
        ))}
      </div>
    </div>
  );
}

export default App;