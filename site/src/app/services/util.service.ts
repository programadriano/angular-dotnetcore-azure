import { Injectable } from '@angular/core';
import { DomSanitizer } from '@angular/platform-browser';

@Injectable({
  providedIn: 'root'
})
export class UtilService {

  constructor(
    private _sanitizer: DomSanitizer
  ) { }

  getBackground(image: String) {
    return this._sanitizer.bypassSecurityTrustStyle(`--c-list-slider__item:url(${image})`);
  }

  getVideo(video: String) {
    return this._sanitizer.bypassSecurityTrustResourceUrl(`https://player.mais.uol.com.br/?mediaId=${video}&amp;autoplay=false&amp;share=false&amp;startHd=720p&amp;related=false`);
  }
}
