import { Project } from './../Models/project';
import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/add/operator/map';

@Injectable()
export class ProjectService {

    constructor(private http: Http) { }

    getProjects(){
        return this.http.get('/api/projects')
            .map(res => res.json());
    }
}