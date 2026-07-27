import { MapContainer, TileLayer, Marker, Popup, Polyline, useMap } from "react-leaflet";
import { useEffect } from "react";

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
    selectedStation: Station | null; 
}

function FitBounds({ stations }: { stations: Station[] }) {
    const map = useMap();

    useEffect(() => {
        if (stations.length === 0) return;

        const bounds = stations.map(station => [
            station.latitude,
            station.longitude
        ] as [number, number]);

        map.fitBounds(bounds, {
            padding: [50, 50]
        });
    }, [stations, map]);

    return null;
}

function FlyToStation({
    selectedStation,
}: {
    selectedStation: Station | null;
}) {
    const map = useMap();

    useEffect(() => {
        if (!selectedStation) return;

        map.flyTo(
            [
                selectedStation.latitude,
                selectedStation.longitude,
            ],
            16,
            {
                duration: 1.5,
            }
        );
    }, [selectedStation, map]);

    return null;
}



function TransitMap({ stations, selectedStation }: TransitMapProps) {
    return (
        <MapContainer
            center={[14.6091, 121.0223]}
            zoom={12}
            style={{
                height: "100%",
                width: "100%",
                borderRadius: "12px"
            }}
        >
            <TileLayer
                attribution="&copy; OpenStreetMap contributors"
                url="https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png"
            />

            <FitBounds stations={stations} />

            <FlyToStation selectedStation={selectedStation} />

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