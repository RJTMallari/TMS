export interface Station {
    id: number;
    name: string;
    railLineId: number;
    sequenceNumber: number;
    latitude: number;
    longitude: number;
    transfer?: string;
    firstTrain?: string;
    lastTrain?: string;
}

export interface RailLine {
    id: number;
    name: string;
    shortName: string;
    primaryColor: string;
}