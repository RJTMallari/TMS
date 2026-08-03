import { useState } from "react";
import { useAuth } from "../context/AuthContext";

function Auth() {
    const [userName, setUserName] = useState("");
    const [email, setEmail] = useState("");
    const [password, setPassword] = useState("");

    const { token, login: saveToken } = useAuth();




    const register = async () => {
        const response = await fetch(
            "http://localhost:5030/api/auth/register",
            {
                method: "POST",
                headers: {
                    "Content-Type": "application/json"
                },
                body: JSON.stringify({
                    userName,
                    email,
                    password
                })
            }
        );

        console.log("Status:", response.status);
        console.log(await response.text());
    };

    const login = async () => {
        const response = await fetch(
            "http://localhost:5030/api/auth/login",
            {
                method: "POST",
                headers: {
                    "Content-Type": "application/json"
                },
                body: JSON.stringify({
                    userName,
                    password
                })
            }
        );

        console.log("Status:", response.status);

        if (response.ok) {
            const data = await response.json();

            console.log("JWT Token:", data.token);

            saveToken(data.token);
        }
        else {
            console.log(await response.text());
        }
    };

    return (
        <div
            style={{
                marginTop: "30px",
                padding: "20px",
                backgroundColor: "#1e293b",
                borderRadius: "12px"
            }}
        >   
            {/*Hidden Login */}
            <h2>Admin Login</h2>

            <input
                placeholder="Username"
                value={userName}
                onChange={(e) => setUserName(e.target.value)}
            />

            <br /><br />

            <input
                placeholder="Email"
                value={email}
                onChange={(e) => setEmail(e.target.value)}
            />

            <br /><br />

            <input
                type="password"
                placeholder="Password"
                value={password}
                onChange={(e) => setPassword(e.target.value)}
            />

            <br /><br />

            {/*
            <button onClick={register}>
                Register
            </button>
            */}
            <button onClick={login}>
                Login
            </button>
            {token && (
                <>
                    <h3>JWT Token</h3>

                    <textarea
                        value={token}
                        readOnly
                        rows={8}
                        cols={70}
                    />
                </>
            )}
        </div>


    );
}

export default Auth;