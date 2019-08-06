import React from 'react';

import './sidebar.scss';

const Sidebar = () => {
	return (
		<div className="sidebar-container">
			<SidebarItem iconName="calendar-alt" />
			<SidebarItem iconName="home-alt" />
			<SidebarItem iconName="metro" />
		</div>
	)
};

const SidebarItem = (props: { iconName: string }) => (
	<a className="item">
		<i className={'uil uil-' + props.iconName}></i>
	</a>
);

export default Sidebar;
