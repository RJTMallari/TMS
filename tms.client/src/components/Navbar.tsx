import { Link } from "react-router-dom";
import { useAuth } from "../context/AuthContext";
import { useNavigate } from "react-router-dom";

function Navbar() {

    const { token, logout } = useAuth();
    const navigate = useNavigate();

    return (
        <nav
            style={{
                display: "flex",
                gap: "20px",
                padding: "15px",
                backgroundColor: "#1e293b",
                borderRadius: "10px",
                marginBottom: "20px"
            }}
        >

            <Link to="/">
                Home
            </Link>


            {!token && (
                <Link to="/login">
                    Login
                </Link>
            )}


            {token && (
                <>
                    <Link to="/admin">
                        Admin
                    </Link>

                    <button
                        onClick={() => {
                            logout();
                            navigate("/");
                        }}
                    >
                        Logout
                    </button>
                </>
            )}

        </nav>
    );
}

export default Navbar;