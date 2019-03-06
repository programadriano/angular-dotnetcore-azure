
import { Component, OnInit, OnDestroy } from '@angular/core';

import { Subscription } from 'rxjs';

import { HomeService } from 'src/app/services/home.service';
import {UtilService} from 'src/app/services/util.service'
import { Destaque } from 'src/app/models/destque.model';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit, OnDestroy {

  public inscricao: Subscription;
  public destaque: Destaque;  

  constructor(
    private homeService: HomeService,
    public utilService: UtilService
  ) { }

  ngOnInit() {
    this.getDestaques()
  }

  getDestaques() {
    this.inscricao = this.homeService.getDestaques().subscribe(result => {     
      this.destaque = result;      
    })
  }

  ngOnDestroy() {
    this.inscricao.unsubscribe();
  }

}
