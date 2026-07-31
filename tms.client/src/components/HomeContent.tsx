import { useEffect, useState } from 'react';
import '../App.css';
import lrt1Fare from "../assets/fares/lrt1.png";
import lrt2Fare from "../assets/fares/lrt2.jpg";
import mrt3Fare from "../assets/fares/mrt3.png";
import TransitMap from "./TransitMap";
import type { Station, RailLine } from "../types/transit";


function InfoCard({
    icon,
    title,
    value
}: {
    icon: string;
    title: string;
    value: string;
}) {
    return (
        <div
            style={{
                backgroundColor: "#334155",
                padding: "16px",
                borderRadius: "12px",
                border: "1px solid #475569"
            }}
        >
            <div
                style={{
                    fontSize: "14px",
                    color: "#94a3b8",
                    marginBottom: "8px"
                }}
            >
                {icon} {title}
            </div>

            <div
                style={{
                    fontSize: "18px",
                    fontWeight: "bold"
                }}
            >
                {value}
            </div>
        </div>
    );
}


function HomeContent() {

    const [currentLineId, setCurrentLineId] = useState<number>(3);
    const [stations, setStations] = useState<Station[]>();
    const [railLines, setRailLines] = useState<RailLine[]>([]);
    const [error, setError] = useState<string | null>(null);
    const [selectedStation, setSelectedStation] = useState<Station | null>(null);
    const [showFareMatrix, setShowFareMatrix] = useState(false);

    const fetchRailLines = async () => {
        try {
            const response = await fetch(
                "http://localhost:5030/api/railLines"
            );

            if (response.ok) {
                const data: RailLine[] = await response.json();
                setRailLines(data);
            }

        } catch (err) {
            console.error("Rail line fetch error:", err);
        }
    }

    // Load stations from backend
    const populateTransitData = async () => {
        try {
            setError(null);
            setStations(undefined); // Resets view 

            const response = await fetch(
                `http://localhost:5030/api/stations/line/${currentLineId}`
            );
            if (response.ok) {
                const data: Station[] = await response.json();
                // Track order is correctly displayed
                const sortedData = data.sort((a, b) => a.sequenceNumber - b.sequenceNumber);
                setStations(sortedData);
            } else {
                setError('Failed to fetch data from the server.');
            }
        } catch (err) {
            console.error("Fetch error:", err);
            setError('Could not connect to the backend API. Check if port 5030 is active.');
        }
    }

    useEffect(() => {
        populateTransitData();
    }, [currentLineId]);


    useEffect(() => {
        fetchRailLines();
    }, []);

    const currentLine = railLines.find(
        line => line.id === currentLineId
    );

    const lineConfig = currentLine || {
        id: 0,
        name: "Transit Line",
        shortName: "Transit Line",
        primaryColor: "#3b82f6"
    };

    const fareMatrix =
        {
            1: lrt1Fare,
            2: lrt2Fare,
            3: mrt3Fare

        }[currentLineId];


    const contents = error
        ? <p style={{ color: '#dc3545' }}><strong>Error:</strong> {error}</p>
        : stations === undefined
            ? <p><em>Loading Stations... Please ensure your backend is running on port 5030.</em></p>
            : <div style={{ position: 'relative', paddingLeft: '32px', textAlign: 'left', maxWidth: '400px', margin: '0 auto' }}>


                <div style={{
                    position: 'absolute',
                    left: '11px',
                    top: '12px',
                    bottom: '30px',
                    width: '4px',
                    backgroundColor: lineConfig.primaryColor,
                    borderRadius: '2px',
                    transition: 'background-color 0.2s ease'
                }} />

                {stations.map(station => (
                    <div key={station.id} onClick={() => setSelectedStation(station)} style={{
                        position: "relative",
                        marginBottom: "16px",
                        cursor: "pointer",
                        backgroundColor:
                            selectedStation?.id === station.id
                                ? "#334155"
                                : "#1e293b",
                        borderRadius: "12px",
                        padding: "16px 20px",
                        transition: "0.2s",
                        border:
                            selectedStation?.id === station.id
                                ? `2px solid ${lineConfig.primaryColor}`
                                : "2px solid transparent"
                    }}>


                        <div style={{
                            position: 'absolute',
                            left: '-27px',
                            top: '6px',
                            width: '12px',
                            height: '12px',
                            borderRadius: '50%',
                            backgroundColor: '#fff',
                            border: `3px solid ${lineConfig.primaryColor}`,
                            transition: 'border-color 0.2s ease'
                        }} />

                        <div
                            style={{
                                display: "flex",
                                justifyContent: "space-between",
                                alignItems: "center"
                            }}
                        >
                            <div>
                                <div
                                    style={{
                                        fontSize: "1.2rem",
                                        fontWeight: 600,
                                        color: "white"
                                    }}
                                >
                                    🚉 {station.name}
                                </div>

                                <div
                                    style={{
                                        fontSize: "0.9rem",
                                        color: "#94a3b8",
                                        marginTop: "4px"
                                    }}
                                >
                                    Stop #{station.sequenceNumber}
                                </div>
                            </div>

                            <div
                                style={{
                                    fontSize: "24px",
                                    color: "#94a3b8"
                                }}
                            >
                                ›
                            </div>
                        </div>
                    </div>
                ))}
            </div>;

    return (
        <div style={{ padding: '20px', fontFamily: 'sans-serif' }}>

            <h1
                style={{
                    color: lineConfig.primaryColor,
                    marginBottom: '4px'
                }}
            >
                {lineConfig.shortName} Tracker
            </h1>
            <p style={{ color: '#9ca3af', marginBottom: '30px' }}>
                Route structural layout
            </p>

            <div style={{
                display: 'flex',
                gap: '10px',
                justifyContent: 'center',
                marginBottom: '40px'
            }}>
                {
                    railLines.map(line => (
                        <button
                            key={line.id}
                            onClick={() => setCurrentLineId(line.id)}
                            style={{
                                padding: '10px 16px',
                                borderRadius: '6px',
                                cursor: 'pointer',
                                border: 'none',
                                fontWeight: 600,
                                background:
                                    currentLineId === line.id
                                        ? line.primaryColor
                                        : '#334155',
                                color: '#fff'
                            }}
                        >
                            {line.shortName}
                        </button>

                    ))
                }
                <button
                    onClick={() => setShowFareMatrix(true)}
                >
                    View Fare Matrix
                </button>
            </div>

            {contents}

            {selectedStation && (
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
                            width: "800px",
                            maxWidth: "90%",
                            backgroundColor: "#1e293b",
                            borderRadius: "16px",
                            overflow: "hidden",
                            border: `3px solid ${lineConfig.primaryColor}`
                        }}
                    >
                        {/* Header */}
                        <div
                            style={{
                                position: "relative",
                                backgroundColor: lineConfig.primaryColor,
                                color: "white",
                                padding: "18px",
                                textAlign: "center"
                            }}
                        >
                            <button
                                onClick={() => setSelectedStation(null)}
                                style={{
                                    position: "absolute",
                                    right: "16px",
                                    top: "16px",
                                    background: "transparent",
                                    border: "none",
                                    color: "white",
                                    fontSize: "24px",
                                    cursor: "pointer"
                                }}
                            >
                                ✕
                            </button>

                            <h2>🚉 {selectedStation.name}</h2>
                        </div>

                        {/* Map */}
                        <div
                            style={{
                                height: "300px"
                            }}
                        >
                            <TransitMap
                                stations={stations ?? []}
                                selectedStation={selectedStation}
                            />
                        </div>

                        {/* Station Info */}

                        <div
                            style={{
                                display: "grid",
                                gridTemplateColumns: "1fr 1fr",
                                gap: "12px",
                                padding: "20px"
                            }}
                        >
                            <InfoCard
                                icon="🚉"
                                title="Station Number"
                                value={`#${selectedStation.sequenceNumber}`}
                            />

                            <InfoCard
                                icon="🔄"
                                title="Transfer"
                                value={selectedStation.transfer ?? "None"}
                            />

                            <InfoCard
                                icon="🕒"
                                title="First Train"
                                value={selectedStation.firstTrain ?? "Coming Soon"}
                            />

                            <InfoCard
                                icon="🌙"
                                title="Last Train"
                                value={selectedStation.lastTrain ?? "Coming Soon"}
                            />
                            <p
                                style={{
                                    marginTop: "18px",
                                    textAlign: "center",
                                    color: "#94a3b8",
                                    fontSize: "0.8rem",
                                    fontStyle: "italic"
                                }}
                            >
                                * * Train schedules are based on official railway timetables where available. Intermediate station times may be estimated for demonstration purposes.
                            </p>

                        </div>
                    </div>
                </div>
            )}




            {showFareMatrix && (
                <div
                    style={{
                        position: "fixed",
                        inset: 0,
                        backgroundColor: "rgba(0,0,0,0.6)",
                        display: "flex",
                        justifyContent: "center",
                        alignItems: "center",
                        zIndex: 1000
                    }}
                >
                    <div
                        style={{
                            width: "800px",
                            maxWidth: "90%",
                            maxHeight: "90vh",
                            backgroundColor: "#1e293b",
                            borderRadius: "16px",
                            overflow: "hidden",
                            border: `3px solid ${lineConfig.primaryColor}`,
                            boxShadow: "0 20px 50px rgba(0,0,0,0.4)"
                        }}
                    >
                        {/* Header */}
                        <div
                            style={{
                                position: "relative",
                                backgroundColor: lineConfig.primaryColor,
                                color: "white",
                                padding: "20px",
                                textAlign: "center"
                            }}
                        >
                            <button
                                onClick={() => setShowFareMatrix(false)}
                                style={{
                                    position: "absolute",
                                    right: "16px",
                                    top: "16px",
                                    background: "transparent",
                                    border: "none",
                                    color: "white",
                                    fontSize: "24px",
                                    cursor: "pointer"
                                }}
                            >
                                X
                            </button>
                            <h2 style={{ margin: 0 }}>
                                💳 {lineConfig.shortName} Fare Matrix
                            </h2>
                        </div>

                        {/* Body */}
                        <div
                            style={{
                                padding: "20px",
                                overflowY: "auto",
                                maxHeight: "70vh"
                            }}
                        >
                            <img
                                src={fareMatrix}
                                alt="Fare Matrix"
                                style={{
                                    width: "100%",
                                    borderRadius: "8px"
                                }}
                            />
                        </div>
                    </div>
                </div>
            )}
        </div>
    );
}

export default HomeContent;