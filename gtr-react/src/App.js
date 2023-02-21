import { Routes, Route } from "react-router-dom";
import Login from "./components/pages/Login";
import Layout from "./components/Layout";
import Manage from "./components/pages/Manage";
import NotFound from "./components/NotFound";
import Index from "./components/pages/Index";

function App() {
  return (
    <>
      <Routes>
        <Route path="login" element={<Login />} />

        <Route element={<Layout />}>
          <Route path="/" element={<Index />} exact />
          <Route path="manage" element={<Manage />} exact />
        </Route>

        <Route path="*" element={<NotFound />} />
      </Routes>
    </>
  );
}

export default App;