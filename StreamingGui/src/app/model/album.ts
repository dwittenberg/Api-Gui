import { Title } from './title';

export interface Album {
    views: number;
    name: string;
    cover: string;
    interpret: string;
    genres: string;
    title: Title[];
}
