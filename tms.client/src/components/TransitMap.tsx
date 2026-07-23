import { MapContainer, TileLayer, Marker, Popup, Polyline } from "react-leaflet";

interface Station {
    id: number;
    name: string;
    railLineId: number;
    sequenceNumber: number;
    latitude: number;
    longitude: number;
}

interface TransitMapProps {
    stations: Station[];
}

function TransitMap({ stations }: TransitMapProps) {
    return (
        <MapContainer
            center={[14.6091, 121.0223]}
            zoom={12}
            style={{
                height: "500px",
                width: "100%",
                borderRadius: "12px"
            }}
        >
            <TileLayer
                attribution="&copy; OpenStreetMap contributors"
                url="https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png"
            />

            <Polyline
                positions={stations.map(station => [
                    station.latitude,
                    station.longitude
                ])}
                pathOptions={{
                    color: "#005EB8",
                    weight: 6
                }}
            />

            {stations.map(station => (
                <Marker
                    key={station.id}
                    position={[station.latitude, station.longitude]}
                >
                    <Popup>
                        <strong>{station.name}</strong>
                        <br />
                        Stop #{station.sequenceNumber}
                    </Popup>
                </Marker>
            ))}
        </MapContainer>
    );
}

export default TransitMap;