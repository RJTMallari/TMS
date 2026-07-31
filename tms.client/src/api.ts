const API_URL = "http://localhost:5030/api";

export async function apiFetch(
    endpoint: string,
    options: RequestInit = {}
) {
    const token = localStorage.getItem("token");

    return fetch(
        `${API_URL}${endpoint}`,
        {
            ...options,
            headers: {
                "Content-Type": "application/json",

                ...(token && {
                    Authorization: `Bearer ${token}`
                }),

                ...options.headers
            }
        }
    );
}