import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { VotersComponent } from "./voters/voters.component";
import { CandidatesComponent } from "./candidates/candidates.component";

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, VotersComponent, CandidatesComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'vote-fe';
}
