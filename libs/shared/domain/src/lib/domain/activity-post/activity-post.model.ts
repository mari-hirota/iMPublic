import { IOneToOne, IManyToOne, IOneToMany } from '@orcha/common';
import { Poi } from '../poi';
import { User } from '../user';
import { Comment } from '../comment';
import { Like } from '../like';


export interface ActivityPost {
  id: string;
  likeCount: number;

  poi: IOneToOne<Poi, 'activityPost'>;
  likes: IOneToMany<Like, 'activityPost'>;
  comments: IOneToMany<Comment, 'activityPost'>;
  user: IManyToOne<User, 'activityPosts'>;

  dateCreated: Date | string;
  enabled: boolean;
}