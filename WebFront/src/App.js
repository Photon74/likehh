import "./App.css";
import LoginForm from "./Components/LoginForm/LoginForm";
import Menu from "./Components/Menu/Menu";

function App() {
  return (
    <div className="App">
      <div className="content">
        <LoginForm />
      </div>
      <Menu />
    </div>
  );
}

export default App;
