package com.techelevator.dao;

import com.techelevator.model.Site;

import java.time.LocalDate;
import java.util.List;

public interface SiteDAO {

    List<Site> getSitesThatAllowRVs(int parkId);
    List<Site> findSitesAvailableToday(int parkId);
}
