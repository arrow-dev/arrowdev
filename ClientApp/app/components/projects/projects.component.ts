import { ProjectService } from './../../services/project.service';
import { Project } from './../../models/project';
import { Component } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'projects',
    templateUrl: './projects.component.html'
})
export class ProjectsComponent {
    public projects: Project[];

    constructor(private projectService: ProjectService) { };
}
