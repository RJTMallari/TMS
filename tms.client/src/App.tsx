import { useEffect, useState } from 'react';
import './App.css';

// Station model 
interface Station {
    id: number;
    name: string;
    railLineId: number;
    sequenceNumber: number;
    latitude: number;
    longitude: number;
}

function App() {
    
    const [currentLineId, setCurrentLineId] = useState<number>(3);
    const [stations, setStations] = useState<Station[]>();
    const [error, setError] = useState<string | null>(null);

   
    useEffect(() => {
        populateTransitData();
    }, [currentLineId]);

    
    const lineConfig = {
        1: { name: "LRT-1", color: "#10b981" },
        2: { name: "LRT-2", color: "#3b82f6" },
        3: { name: "MRT-3", color: "#eab308" }
    }[currentLineId] || { name: "Transit Line", color: "#3b82f6" };

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
                    backgroundColor: lineConfig.color,
                    borderRadius: '2px',
                    transition: 'background-color 0.2s ease'
                }} />

                {stations.map(station => (
                    <div key={station.id} style={{ position: 'relative', marginBottom: '32px' }}>

                        
                        <div style={{
                            position: 'absolute',
                            left: '-27px',
                            top: '6px',
                            width: '12px',
                            height: '12px',
                            borderRadius: '50%',
                            backgroundColor: '#fff',
                            border: `3px solid ${lineConfig.color}`,
                            transition: 'border-color 0.2s ease'
                        }} />

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
            <h1 id="tableLabel" style={{ color: lineConfig.color, marginBottom: '4px', transition: 'color 0.2s ease' }}>
                {lineConfig.name} Tracker
            </h1>
            <p style={{ color: '#9ca3af', marginBottom: '30px' }}>Route structural layout</p>

            
            <div style={{ display: 'flex', gap: '10px', justifyContent: 'center', marginBottom: '40px' }}>
                <button
                    onClick={() => setCurrentLineId(1)}
                    style={{ padding: '10px 16px', borderRadius: '6px', cursor: 'pointer', border: 'none', fontWeight: 600, background: currentLineId === 1 ? '#10b981' : '#334155', color: '#fff' }}
                >
                    LRT-1
                </button>
                <button
                    onClick={() => setCurrentLineId(2)}
                    style={{ padding: '10px 16px', borderRadius: '6px', cursor: 'pointer', border: 'none', fontWeight: 600, background: currentLineId === 2 ? '#3b82f6' : '#334155', color: '#fff' }}
                >
                    LRT-2
                </button>
                <button
                    onClick={() => setCurrentLineId(3)}
                    style={{ padding: '10px 16px', borderRadius: '6px', cursor: 'pointer', border: 'none', fontWeight: 600, background: currentLineId === 3 ? '#eab308' : '#334155', color: '#fff' }}
                >
                    MRT-3
                </button>
            </div>

            {contents}
        </div>
    );

    // Load stations from backend
    async function populateTransitData() {
        try {
            setError(null);
            setStations(undefined); // Resets view 

            const response = await fetch(`http://localhost:5030/api/transitdata/stations/${currentLineId}`);
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
}

export default App;