import { useEffect, useState } from "react";
import type { Station } from "../types/transit";


function StationManagement() {

    const [stations, setStations] = useState<Station[]>([]);

    useEffect(() => {
        fetch("http://localhost:5030/api/stations")
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
                                {station.transfer ? "Yes" : "No"}
                            </td>
                        </tr>
                    ))}
                </tbody>
            </table>
        </div>
    );
}

export default StationManagement;