import { Routes, Route } from "react-router-dom";
import HomeContent from "./components/HomeContent";
import StationManagement from "./components/StationManagement";
import ProtectedRoute from "./components/ProtectedRoute";
import Login from "./pages/Login";
import Navbar from "./components/Navbar";

function App() {
    return (
        <div style={{ padding: "20px", fontFamily: "sans-serif" }}>

            <Navbar />

            <Routes>

                <Route
                    path="/"
                    element={<HomeContent />}
                />

                <Route
                    path="/login"
                    element={<Login />}
                />

                <Route
                    path="/admin"
                    element={
                        <ProtectedRoute>
                            <StationManagement />
                        </ProtectedRoute>
                    }
                />

            </Routes>

        </div>
    );
}

export default App;