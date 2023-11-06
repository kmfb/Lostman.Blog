import type { CreateUpdatePostDto, PostDto } from './models';
import { RestService, Rest } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class PostService {
  apiName = 'Default';
  

  create = (input: CreateUpdatePostDto, config?: Partial<Rest.Config>) =>
    this.restService.request<any, PostDto>({
      method: 'POST',
      url: '/api/app/post',
      body: input,
    },
    { apiName: this.apiName,...config });
  

  delete = (id: string, config?: Partial<Rest.Config>) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/post/${id}`,
    },
    { apiName: this.apiName,...config });
  

  get = (id: string, config?: Partial<Rest.Config>) =>
    this.restService.request<any, PostDto>({
      method: 'GET',
      url: `/api/app/post/${id}`,
    },
    { apiName: this.apiName,...config });
  

  getList = (input: PagedAndSortedResultRequestDto, config?: Partial<Rest.Config>) =>
    this.restService.request<any, PagedResultDto<PostDto>>({
      method: 'GET',
      url: '/api/app/post',
      params: { sorting: input.sorting, skipCount: input.skipCount, maxResultCount: input.maxResultCount },
    },
    { apiName: this.apiName,...config });
  

  update = (id: string, input: CreateUpdatePostDto, config?: Partial<Rest.Config>) =>
    this.restService.request<any, PostDto>({
      method: 'PUT',
      url: `/api/app/post/${id}`,
      body: input,
    },
    { apiName: this.apiName,...config });

  constructor(private restService: RestService) {}
}
