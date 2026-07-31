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

    const updateStation = async () => {

        if (!editingStation) return;

        console.log("Sending:", editingStation);
        console.log(JSON.stringify(editingStation, null, 2));

        const response = await apiFetch(
            `/stations/${editingStation.id}`,
            {
                method: "PUT",
                body: JSON.stringify({
                    id: editingStation.id,
                    name: editingStation.name,
                    railLineId: editingStation.railLineId,
                    sequenceNumber: editingStation.sequenceNumber,
                    latitude: editingStation.latitude,
                    longitude: editingStation.longitude,
                    transfer: editingStation.transfer,
                    firstTrain: editingStation.firstTrain,
                    lastTrain: editingStation.lastTrain
                })
            }
        );

        console.log("Status:", response.status);
        console.log("Message:", await response.text());


        if (response.ok) {
            setStations(
                stations.map(station =>
                    station.id === editingStation.id
                        ? editingStation
                        : station
                )

            );
        }

        setEditingStation(null);
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

            <p>Total Stations: {stations.length}</p>

            <div>
                <h3>Add New Station</h3>

                <input
                    placeholder="Station Name"
                    value={newStation.name}
                    onChange={(e) =>
                        setNewStation({
                            ...newStation,
                            name: e.target.value
                        })
                    }
                />

                <button
                    onClick={createStation}
                    style={{
                        backgroundColor: "blue",
                        color: "white",
                        border: "none",
                        padding: "8px 15px",
                        borderRadius: "5px",
                        cursor: "pointer",
                        marginTop: "10px"
                    }}
                >
                    Add Station
                </button>
            </div>

            {editingStation && (
                <div>
                    <h3>Edit Station: {editingStation.name}</h3>

                    <label>
                        Station Name:
                    </label>

                    <input
                        value={editingStation.name}
                        onChange={(e) =>
                            setEditingStation({
                                ...editingStation,
                                name: e.target.value
                            })
                        }
                    />
                    <button
                        onClick={updateStation}
                        style={{
                            backgroundColor: "green",
                            color: "white",
                            border: "none",
                            padding: "8px 15px",
                            borderRadius: "5px",
                            cursor: "pointer",
                            marginTop: "10px"
                        }}
                    >
                        Save Changes
                    </button>
                </div>
            )}

            <table
                style={{
                    width: "100%",
                    marginTop: "20px",
                    borderCollapse: "collapse"
                }}
            >
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Name</th>
                        <th>Rail Line</th>
                        <th>Sequence</th>
                        <th>First Train</th>
                        <th>Last Train</th>
                        <th>Transfer</th>
                        <th>Actions</th>
                    </tr>
                </thead>

                <tbody>
                    {stations.map(station => (
                        <tr key={station.id}>
                            <td>{station.id}</td>
                            <td>{station.name}</td>
                            <td>{station.railLineId}</td>
                            <td>{station.sequenceNumber}</td>
                            <td>{station.firstTrain}</td>
                            <td>{station.lastTrain}</td>
                            <td>
                                {station.transfer ?? "None"}
                            </td>
                            <td>
                                <button
                                    onClick={() => deleteStation(station.id)}
                                    style={{
                                        backgroundColor: "red",
                                        color: "white",
                                        border: "none",
                                        padding: "6px 12px",
                                        borderRadius: "5px",
                                        cursor: "pointer"
                                    }}
                                >
                                    Delete
                                </button>
                            </td>
                            <td>
                                <button
                                    onClick={() => editStation(station)}
                                >
                                    Edit
                                </button>
                            </td>
                        </tr>
                    ))}
                </tbody>
            </table>
        </div>
    );
}

export default StationManagement;