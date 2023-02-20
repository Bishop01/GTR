import { Routes, Route } from "react-router-dom";
import Login from "./components/pages/Login";

function App() {
  return (
    <>
      <Routes>
        <Route path="login" element={<Login />} />

        {/* <Route element={<Layout />}>
          <Route path="/" element={<Dashboard />} exact />
        </Route> */}
      </Routes>
    </>
  );
}

export default App;