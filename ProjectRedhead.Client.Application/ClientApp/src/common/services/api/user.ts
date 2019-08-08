import ApiService from "./api";

export interface User {
	displayName?: string;
	role?: string;
	points?: number;
}

export class UserApiService extends ApiService {
	async getCurrentUser(): Promise<User> {
		let user = await this.getHttp<User>('user');
		return user;
	}
}

export default new UserApiService();
