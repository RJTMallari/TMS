import { useEffect, useState } from 'react';
import './App.css';

// 1. Define the TypeScript blueprint for your MRT-3 stations
interface Station {
    id: number;
    name: string;
    railLineId: number;
    sequenceNumber: number;
    latitude: number;
    longitude: number;
}

function App() {
    const [stations, setStations] = useState<Station[]>();
    const [error, setError] = useState<string | null>(null);

    useEffect(() => {
        populateTransitData();
    }, []);

    // 2. Build the UI layout based on whether data has loaded
    const contents = error
        ? <p style={{ color: '#dc3545' }}><strong>Error:</strong> {error}</p>
        : stations === undefined
            ? <p><em>Loading MRT-3 Stations... Please ensure your backend is running on port 5030.</em></p>
            : <div style={{ position: 'relative', paddingLeft: '32px', textAlign: 'left', maxWidth: '400px', margin: '0 auto' }}>

                {/* Visual Timeline Track Line */}
                <div style={{
                    position: 'absolute',
                    left: '11px',
                    top: '12px',
                    bottom: '30px',
                    width: '4px',
                    backgroundColor: '#3b82f6',
                    borderRadius: '2px'
                }} />

                {/* Loop through your station data */}
                {stations.map(station => (
                    <div key={station.id} style={{ position: 'relative', marginBottom: '32px' }}>

                        {/* Station Bullet Node */}
                        <div style={{
                            position: 'absolute',
                            left: '-27px',
                            top: '6px',
                            width: '12px',
                            height: '12px',
                            borderRadius: '50%',
                            backgroundColor: '#fff',
                            border: '3px solid #3b82f6',
                        }} />

                        {/* Station Details */}
                        <div>
                            <div style={{ fontSize: '1.2rem', fontWeight: 600, color: '#fff' }}>
                                {station.name}
                            </div>
                            <div style={{ fontSize: '0.85rem', color: '#9ca3af', marginTop: '2px' }}>
                                Stop #{station.sequenceNumber} • Lat: {station.latitude} | Lon: {station.longitude}
                            </div>
                        </div>
                    </div>
                ))}
            </div>;

    return (
        <div style={{ padding: '20px', fontFamily: 'sans-serif' }}>
            <h1 id="tableLabel" style={{ color: '#3b82f6', marginBottom: '4px' }}>Line 3 Tracker</h1>
            <p style={{ color: '#9ca3af', marginBottom: '40px' }}>Real-time route structural layout</p>
            {contents}
        </div>
    );

    // 3. Fetch straight from your live backend HTTP port
    async function populateTransitData() {
        try {
            const response = await fetch('http://localhost:5030/api/transitdata/stations/3');
            if (response.ok) {
                const data: Station[] = await response.json();
                // Ensure they display in the correct track order
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
}

export default App;