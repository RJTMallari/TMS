import { useEffect, useState } from "react";
import type { Station } from "../types/transit";
import { apiFetch } from "../api";

function StationManagement() {

    const [stations, setStations] = useState<Station[]>([]);
    const [editingStation, setEditingStation] = useState<Station | null>(null);
    const [newStation, setNewStation] = useState({
        name: "",
        railLineId: 1,
        sequenceNumber: 1,
        latitude: 0,
        longitude: 0,
        transfer: "None",
        firstTrain: "",
        lastTrain: ""
    });

    useEffect(() => {
        apiFetch("/stations")
            .then(response => {
                console.log("Status:", response.status);
                return response.json();
            })
            .then(data => {
                console.log("Data:", data);
                setStations(data);
            })
            .catch(error => console.error(error));
    }, []);

    const editStation = (station: Station) => {
        console.log("Editing:", station);
        setEditingStation(station);
    };

    const deleteStation = async (id: number) => {
        const confirmed = window.confirm(
            "Are you sure you want to delete this station?"
        );

        if (!confirmed) return;

        await apiFetch(`/stations/${id}`, {
            method: "DELETE",
        });

        setStations(
            stations.filter(station => station.id !== id)
        );
    };


    const createStation = async () => {
        const response = await apiFetch(
            "/stations",
            {
                method: "POST",
                body: JSON.stringify(newStation)
            }
        );

        if (response.ok) {
            const createdStation = await response.json();

            setStations([
                ...stations,
                createdStation
            ]);

            setNewStation({
                name: "",
                railLineId: 1,
                sequenceNumber: 1,
                latitude: 0,
                longitude: 0,
                transfer: "None",
                firstTrain: "",
                lastTrain: ""
            });
        }
    };

    return (
        <div
            style={{
                marginTop: "30px",
                padding: "20px",
                backgroundColor: "#1e293b",
                borderRadius: "12px",
                border: "1px solid #475569"
            }}
        >
            <h2>🚉 Station Management</h2>

            <p>
                CRUD interface.
            </p>

            <div
                style={{
                    display: "flex",
                    justifyContent: "space-between",
                    alignItems: "center",
                    marginBottom: "25px"
                }}
            >
                <div>
                    <h2
                        style={{
                            margin: 0,
                            color: "#38bdf8"
                        }}
                    >
                        🚉 Station Management
                    </h2>

                    <p
                        style={{
                            color: "#94a3b8",
                            marginTop: "8px"
                        }}
                    >
                        Manage stations for all rail lines.
                    </p>
                </div>

                <div
                    style={{
                        backgroundColor: "#334155",
                        padding: "15px 20px",
                        borderRadius: "10px",
                        textAlign: "center",
                        minWidth: "140px"
                    }}
                >
                    <div
                        style={{
                            fontSize: "28px",
                            fontWeight: "bold"
                        }}
                    >
                        {stations.length}
                    </div>

                    <div
                        style={{
                            color: "#94a3b8"
                        }}
                    >
                        Total Stations
                    </div>
                </div>
            </div>

            <div
                style={{
                    backgroundColor: "#334155",
                    padding: "20px",
                    borderRadius: "12px",
                    marginBottom: "25px"
                }}
            >
                <h3
                    style={{
                        marginTop: 0,
                        marginBottom: "15px"
                    }}
                >
                    ➕ Add New Station
                </h3>

                <div
                    style={{
                        display: "flex",
                        gap: "12px",
                        alignItems: "center",
                        flexWrap: "wrap"
                    }}
                >
                    <input
                        placeholder="Station Name"
                        value={newStation.name}
                        onChange={(e) =>
                            setNewStation({
                                ...newStation,
                                name: e.target.value
                            })
                        }
                        style={{
                            flex: 1,
                            minWidth: "250px",
                            padding: "10px",
                            borderRadius: "8px",
                            border: "1px solid #475569",
                            backgroundColor: "#1e293b",
                            color: "white"
                        }}
                    />

                    <button
                        onClick={createStation}
                        style={{
                            backgroundColor: "#22c55e",
                            color: "white",
                            border: "none",
                            padding: "10px 20px",
                            borderRadius: "8px",
                            cursor: "pointer",
                            fontWeight: "bold"
                        }}
                    >
                        ➕ Add Station
                    </button>
                </div>
            </div>

            {editingStation && (
                <div
                    style={{
                        position: "fixed",
                        inset: 0,
                        backgroundColor: "rgba(0,0,0,0.6)",
                        display: "flex",
                        justifyContent: "center",
                        alignItems: "center",
                        zIndex: 2000
                    }}
                >
                    <div
                        style={{
                            width: "600px",
                            maxWidth: "90%",
                            backgroundColor: "#1e293b",
                            borderRadius: "16px",
                            overflow: "hidden",
                            border: "2px solid #3b82f6"
                        }}
                    >
                        {/* Header */}

                        <div
                            style={{
                                backgroundColor: "#3b82f6",
                                color: "white",
                                padding: "18px",
                                display: "flex",
                                justifyContent: "space-between",
                                alignItems: "center"
                            }}
                        >
                            <h2 style={{ margin: 0 }}>
                                ✏️ Edit Station
                            </h2>

                            <button
                                onClick={() => setEditingStation(null)}
                                style={{
                                    background: "transparent",
                                    border: "none",
                                    color: "white",
                                    fontSize: "24px",
                                    cursor: "pointer"
                                }}
                            >
                                ✕
                            </button>
                        </div>

                        {/* Body */}

                        <div
                            style={{
                                padding: "25px"
                            }}
                        >
                            <div
                                style={{
                                    display: "flex",
                                    flexDirection: "column",
                                    gap: "18px"
                                }}
                            >
                                <div>
                                    <label
                                        style={{
                                            display: "block",
                                            marginBottom: "8px",
                                            fontWeight: "bold"
                                        }}
                                    >
                                        🚉 Station Name
                                    </label>

                                    <input
                                        value={editingStation.name}
                                        onChange={(e) =>
                                            setEditingStation({
                                                ...editingStation,
                                                name: e.target.value
                                            })
                                        }
                                        style={{
                                            width: "100%",
                                            padding: "10px",
                                            borderRadius: "8px",
                                            border: "1px solid #475569",
                                            backgroundColor: "#334155",
                                            color: "white",
                                            boxSizing: "border-box"
                                        }}
                                    />
                                </div>

                                <div>
                                    <label
                                        style={{
                                            display: "block",
                                            marginBottom: "8px",
                                            fontWeight: "bold"
                                        }}
                                    >
                                        🚆 Rail Line
                                    </label>

                                    <select
                                        value={editingStation.railLineId}
                                        onChange={(e) =>
                                            setEditingStation({
                                                ...editingStation,
                                                railLineId: Number(e.target.value)
                                            })
                                        }
                                        style={{
                                            width: "100%",
                                            padding: "10px",
                                            borderRadius: "8px",
                                            border: "1px solid #475569",
                                            backgroundColor: "#334155",
                                            color: "white"
                                        }}
                                    >
                                        <option value={1}>LRT-1</option>
                                        <option value={2}>LRT-2</option>
                                        <option value={3}>MRT-3</option>
                                    </select>
                                </div>
                                <div>
                                    <label
                                        style={{
                                            display: "block",
                                            marginBottom: "8px",
                                            fontWeight: "bold"
                                        }}
                                    >
                                        🔢 Sequence Number
                                    </label>

                                    <input
                                        type="number"
                                        value={editingStation.sequenceNumber}
                                        onChange={(e) =>
                                            setEditingStation({
                                                ...editingStation,
                                                sequenceNumber: Number(e.target.value)
                                            })
                                        }
                                        style={{
                                            width: "100%",
                                            padding: "10px",
                                            borderRadius: "8px",
                                            border: "1px solid #475569",
                                            backgroundColor: "#334155",
                                            color: "white",
                                            boxSizing: "border-box"
                                        }}
                                    />
                                </div>
                                <div>
                                    <label
                                        style={{
                                            display: "block",
                                            marginBottom: "8px",
                                            fontWeight: "bold"
                                        }}
                                    >
                                        🔢 Sequence Number
                                    </label>

                                    <input
                                        type="number"
                                        value={editingStation.sequenceNumber}
                                        onChange={(e) =>
                                            setEditingStation({
                                                ...editingStation,
                                                sequenceNumber: Number(e.target.value)
                                            })
                                        }
                                        style={{
                                            width: "100%",
                                            padding: "10px",
                                            borderRadius: "8px",
                                            border: "1px solid #475569",
                                            backgroundColor: "#334155",
                                            color: "white",
                                            boxSizing: "border-box"
                                        }}
                                    />
                                </div>
                                <div
                                    style={{
                                        display: "grid",
                                        gridTemplateColumns: "1fr 1fr",
                                        gap: "15px"
                                    }}
                                >
                                    <div>
                                        <label>🕒 First Train</label>

                                        <input
                                            value={editingStation.firstTrain ?? ""}
                                            onChange={(e) =>
                                                setEditingStation({
                                                    ...editingStation,
                                                    firstTrain: e.target.value
                                                })
                                            }
                                            style={{
                                                width: "100%",
                                                padding: "10px",
                                                borderRadius: "8px",
                                                backgroundColor: "#334155",
                                                color: "white",
                                                border: "1px solid #475569",
                                                boxSizing: "border-box"
                                            }}
                                        />
                                    </div>

                                    <div>
                                        <label>🌙 Last Train</label>

                                        <input
                                            value={editingStation.lastTrain ?? ""}
                                            onChange={(e) =>
                                                setEditingStation({
                                                    ...editingStation,
                                                    lastTrain: e.target.value
                                                })
                                            }
                                            style={{
                                                width: "100%",
                                                padding: "10px",
                                                borderRadius: "8px",
                                                backgroundColor: "#334155",
                                                color: "white",
                                                border: "1px solid #475569",
                                                boxSizing: "border-box"
                                            }}
                                        />
                                    </div>
                                    <div>
                                        <label
                                            style={{
                                                display: "block",
                                                marginBottom: "8px",
                                                fontWeight: "bold"
                                            }}
                                        >
                                            🔄 Transfer
                                        </label>

                                        <input
                                            value={editingStation.transfer ?? ""}
                                            onChange={(e) =>
                                                setEditingStation({
                                                    ...editingStation,
                                                    transfer: e.target.value
                                                })
                                            }
                                            style={{
                                                width: "100%",
                                                padding: "10px",
                                                borderRadius: "8px",
                                                backgroundColor: "#334155",
                                                color: "white",
                                                border: "1px solid #475569",
                                                boxSizing: "border-box"
                                            }}
                                        />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            )}

            <table
                style={{
                    width: "100%",
                    marginTop: "20px",
                    borderCollapse: "collapse",
                    overflow: "hidden",
                    borderRadius: "12px",
                    backgroundColor: "#1e293b"
                }}
            >
                <thead
                    style={{
                        backgroundColor: "#0f172a"
                    }}
                >
                    <tr>
                        <th style={{ padding: "14px" }}>ID</th>
                        <th style={{ padding: "14px" }}>Name</th>
                        <th style={{ padding: "14px" }}>Rail Line</th>
                        <th style={{ padding: "14px" }}>Sequence</th>
                        <th style={{ padding: "14px" }}>First Train</th>
                        <th style={{ padding: "14px" }}>Last Train</th>
                        <th style={{ padding: "14px" }}>Transfer</th>
                        <th style={{ padding: "14px" }}>Actions</th>
                    </tr>
                </thead>

                <tbody>
                    {stations.map(station => (
                        <tr
                            key={station.id}
                            style={{
                                borderBottom: "1px solid #334155"
                            }}
                        >
                            <td style={{ padding: "12px", textAlign: "center" }}>{station.id}</td>
                            <td style={{ padding: "12px", textAlign: "center" }}>{station.name}</td>
                            <td style={{ padding: "12px", textAlign: "center" }}>{station.railLineId}</td>
                            <td style={{ padding: "12px", textAlign: "center" }}>{station.sequenceNumber}</td>
                            <td style={{ padding: "12px", textAlign: "center" }}>{station.firstTrain}</td>
                            <td style={{ padding: "12px", textAlign: "center" }}>{station.lastTrain}</td>
                            <td style={{ padding: "12px", textAlign: "center" }}>
                                {station.transfer ?? "None"}
                            </td>
                            <td
                                style={{
                                    padding: "12px",
                                    textAlign: "center"
                                }}
                            >
                                {/* Delete button */}

                                {/* Edit button */}
                                <button
                                    onClick={() => deleteStation(station.id)}
                                    style={{
                                        backgroundColor: "#ef4444",
                                        color: "white",
                                        border: "none",
                                        padding: "8px 14px",
                                        borderRadius: "8px",
                                        cursor: "pointer",
                                        fontWeight: "bold",
                                        marginRight: "8px"
                                    }}
                                >
                                    🗑 Delete
                                </button>
                            <td style={{ padding: "12px", textAlign: "center" }}>
                                <button
                                    onClick={() => editStation(station)}
                                    style={{
                                        backgroundColor: "#3b82f6",
                                        color: "white",
                                        border: "none",
                                        padding: "8px 14px",
                                        borderRadius: "8px",
                                        cursor: "pointer",
                                        fontWeight: "bold"
                                    }}
                                >
                                        ✏️ Edit
                                    </button>
                                </td>
                            </td>
                        </tr>
                    ))}
                </tbody>
            </table>
        </div>
    );
}

export default StationManagement;